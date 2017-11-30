using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Image.Ocr.RNReactNativeImageOcr
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeImageOcrModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeImageOcrModule"/>.
        /// </summary>
        internal RNReactNativeImageOcrModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeImageOcr";
            }
        }
    }
}
