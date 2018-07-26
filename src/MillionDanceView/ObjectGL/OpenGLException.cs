﻿using System;
using JetBrains.Annotations;

namespace MillionDanceView.ObjectGL {
    public class OpenGLException : ApplicationException {

        public OpenGLException() {
        }

        public OpenGLException([NotNull] string message)
            : base(message) {
        }

        public OpenGLException([NotNull] string message, [NotNull] Exception innerException)
            : base(message, innerException) {
        }

    }
}
