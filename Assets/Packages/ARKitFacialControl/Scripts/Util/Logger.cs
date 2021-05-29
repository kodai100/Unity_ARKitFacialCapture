using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ProjectBlue.FacialCapture
{

    public class Logger : MonoBehaviour
    {

        [SerializeField]
        Text logText;

        [SerializeField]
        int numHoldLines = 5;

        FixedSizedQueue<string> queue;

        int logLine = 1;

        private void Awake()
        {
            Application.logMessageReceived += OnLogMessage;


            queue = new FixedSizedQueue<string>();
            queue.Limit = numHoldLines;


        }

        private void OnDestroy()
        {
            Application.logMessageReceived -= OnLogMessage;
        }


        private void OnLogMessage(string i_logText, string i_stackTrace, LogType i_type)
        {
            if (string.IsNullOrEmpty(i_logText))
            {
                return;
            }


            queue.Enqueue($"{logLine} : {i_logText}");

            string str = "";
            foreach (var elem in queue.Get())
            {
                str += $"{elem}\n\n";
            }

            logText.text = str;

            logLine++;
        }
    }


    public class FixedSizedQueue<T>
    {
        ConcurrentQueue<T> q = new ConcurrentQueue<T>();
        private object lockObject = new object();

        public int Limit { get; set; }
        public void Enqueue(T obj)
        {
            q.Enqueue(obj);
            lock (lockObject)
            {
                T overflow;
                while (q.Count > Limit && q.TryDequeue(out overflow)) ;
            }
        }

        public IEnumerable<T> Get()
        {
            return q;
        }
    }

}