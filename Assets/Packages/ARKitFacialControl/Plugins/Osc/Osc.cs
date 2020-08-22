// Osc.cs - A minimal OSC receiver implementation for Unity.
// https://github.com/keijiro/unity-osc
using System;
using System.Text;

namespace ProjectBlue.FacialCapture.Core {

    using MessageQueue = System.Collections.Generic.Queue<Message>;
    
	public struct Message {
        public string path;
        public object[] data;
        
		public override string ToString () {
			var buf = new StringBuilder();
            buf.AppendFormat("path={0} : ", path);
			for (var i = 0; i < data.Length; i++)
				buf.AppendFormat("data[{0}]={1}, ", i, data[i]);
            return buf.ToString();
        }
    }
    
	public class Parser {
        #region General private members
        MessageQueue messageBuffer;
        #endregion
        
        #region Temporary read buffer
        Byte[] readBuffer;
		int readBufferLength;
        int readPoint;
        #endregion
        
        #region Public members
        public int MessageCount {
            get { return messageBuffer.Count; }
        }
        
		public Parser () {
            messageBuffer = new MessageQueue ();
        }        
		public Message PopMessage () {
            return messageBuffer.Dequeue ();
        }        
		public void FeedData (Byte[] data, int length) {
            readBuffer = data;
			readBufferLength = length;
            readPoint = 0;
            
            ReadMessage ();
            
            readBuffer = null;
        }
        #endregion
        
        #region Private methods
		void ReadMessage () {
            var path = ReadString ();
            
            if (path == "#bundle") {
                ReadInt64 ();
                
                while (true) {
                    if (readPoint >= readBufferLength)
                        return;
                    var peek = readBuffer [readPoint];
                    if (peek == '/' || peek == '#') {
                        ReadMessage ();
                        return;
                    }
                    var bundleEnd = readPoint + ReadInt32 ();
                    while (readPoint < bundleEnd)
                        ReadMessage ();
                }
            }
            
            var temp = new Message ();
            temp.path = path;
            
            var types = ReadString ();
			temp.data = new object[types.Length - 1];            
            for (var i = 0; i < types.Length - 1; i++) {
                switch (types [i + 1]) {
                case 'f':
                    temp.data [i] = ReadFloat32 ();
                    break;
                case 'i':
                    temp.data [i] = ReadInt32 ();
                    break;
                case 's':
                    temp.data [i] = ReadString ();
                    break;
                case 'b':
                    temp.data [i] = ReadBlob ();
                    break;
                }
            }
            
            messageBuffer.Enqueue (temp);
        }
        
		float ReadFloat32 () {
            var union32 = new OscMessageEncoder.Union32();
            union32.Unpack(readBuffer, readPoint);
            readPoint += 4;
            return union32.floatdata;
        }
        
        int ReadInt32 () {
            var union32 = new OscMessageEncoder.Union32();
            union32.Unpack(readBuffer, readPoint);
            readPoint += 4;
            return union32.intdata;
        }
        
		long ReadInt64 () {
			var union64 = new OscMessageEncoder.Union64 ();
			union64.Unpack (readBuffer, readPoint);
            readPoint += 8;
			return union64.intdata;
        }
        
		string ReadString () {
            var offset = 0;
            while (readBuffer[readPoint + offset] != 0)
                offset++;
            var s = System.Text.Encoding.UTF8.GetString (readBuffer, readPoint, offset);
            readPoint += (offset + 4) & ~3;
            return s;
        }
        
		Byte[] ReadBlob () {
            var length = ReadInt32 ();
            var temp = new Byte[length];
            Array.Copy (readBuffer, readPoint, temp, 0, length);
            readPoint += (length + 3) & ~3;
            return temp;
        }
        #endregion
    }
}