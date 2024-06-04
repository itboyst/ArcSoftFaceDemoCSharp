using System;

namespace ArcFaceSDK.SDKModels
{
    public struct ASF_FaceAttributeInfo
    {
        /// <summary>
        /// 戴眼镜状态, 0 未戴眼镜；1 戴眼镜；2 墨镜
        /// </summary>
        public IntPtr wearGlasses;

        /// <summary>
        /// 左眼状态 0 闭眼；1 睁眼
        /// </summary>
        public IntPtr leftEyeOpen;

        /// <summary>
        /// 右眼状态 0 闭眼；1 睁眼
        /// </summary>
        public IntPtr rightEyeOpen;

        /// <summary>
        /// 张嘴状态 0 张嘴；1 合嘴
        /// </summary>
        public IntPtr mouthClose;
    }
}
