/*
 * Copyright (c) House of Wire 2017 
 * ExecutionTimer 
 * by Danny Gallagher on 22/11/2017
 */

using System;
using System.Diagnostics;

// using Debug = UnityEngine.Debug;

namespace hUtility
{
    public class ExecutionTimer : IDisposable
    {
        private readonly string _description;
        private readonly Action _onComplete;

        private readonly Stopwatch _stopWatch;

        public ExecutionTimer(string description, Action onComplete)
        {
            _onComplete = onComplete;
            _description = description;
            _stopWatch = Stopwatch.StartNew();
        }

        public void Dispose()
        {
            _stopWatch.Stop();
            // Debug.Log(_description + " took " + _stopWatch.Elapsed.TotalSeconds + "s to execute.");
            if (_onComplete != null)
                _onComplete();
        }
    }
}