namespace Timer
{
    using System;
    using System.Threading;

    public class Timer
    {
        private int ticks;
        private int t;

        public Timer(Action<int> method, int ticks, int t)
        {
            this.MethodToExecute = method;
            this.Ticks = ticks;
            this.T = t;
        }

        public Action<int> MethodToExecute { get; private set; }

        public int Ticks
        {
            get { return this.ticks; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("ticks", "The method should be executed at least once.");
                }

                this.ticks = value;
            }
        }

        public int T
        {
            get { return this.t; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("t", "The sleep time cannot be negative.");
                }

                this.t = value;
            }
        }

        public void ExecuteAction()
        {
            Thread parallelThread = new Thread(this.Run);
            parallelThread.Start();
        }

        private void Run()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
                Thread.Sleep(this.T);
                Random random = new Random();

                this.MethodToExecute?.Invoke(random.Next(33, 127));

                // same as:
                /*if (this.MethodToExecute != null)
                {
                    this.MethodToExecute(random.Next(33, 127));
                }*/
            }
        }
    }
}