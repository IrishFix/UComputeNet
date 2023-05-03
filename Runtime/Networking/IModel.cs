﻿using System;
using tensormathdotnet.Runtime.Networking;

// ReSharper disable once CheckNamespace
namespace TensorMath.Networking {
    public interface IModel {
        public MLP Build(int InputCount);
        public MLP Compile(IInitializer Initializer);
        public double[][] Forward(double[][] Batch);

        public MLP Fit(double[][][] X, double[][][] y, int Epochs, IOptimizer Optimizer);
    }
}