using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DesafioCSharpRest.Utils
{
    internal sealed class SyncUtils
    {
        private SyncUtils() { }

        private static System.Threading.Timer _timer;
        public static void startSync()
        {
            
            if (_timer != null)
                _timer.Dispose();

            var state = new AutoResetEvent(false);
            _timer = new System.Threading.Timer(performSync, state, 0, 1 * 10 * 1000);
        } 

        private static void performSync(object? state)
        {
            MessageBox.Show(state + "");
        }

        public static void stopSync()
        {
            if(_timer != null)
            {
                _timer.Dispose();
            }
        }
    }
}
