

namespace ArcFaceSDK.Entity
{
    public class FaceAttributeInfo
    {
        /// <summary>
        /// 戴眼镜状态, 0 未戴眼镜 1 戴眼镜 2 墨镜
        /// </summary>
        public int[] wearGlasses { get; set; }

        /// <summary>
        /// 左眼状态 0 闭眼；1 睁眼
        /// </summary>
        public int[] leftEyeOpen { get; set; }

        /// <summary>
        /// 右眼状态 0 闭眼；1 睁眼
        /// </summary>
        public int[] rightEyeOpen { get; set; }

        /// <summary>
        ///  张嘴状态 0 张嘴；1 合嘴
        /// </summary>
        public int[] mouthClose { get; set; }
       
    }
}
