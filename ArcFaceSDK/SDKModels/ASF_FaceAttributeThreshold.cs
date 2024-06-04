
namespace ArcFaceSDK.SDKModels
{
    public struct ASF_FaceAttributeThreshold
    {
        /// <summary>
        /// 睁眼幅度阈值，阈值越大睁眼幅度越大 取值范围[0,1]
        /// </summary>
        public float eyeOpenThreshold;

        /// <summary>
        /// 张嘴幅度阈值，阈值越大，张嘴幅度越小 取值范围[0,1]
        /// </summary>
        public float mouthCloseThreshold;

        /// <summary>
        /// 佩戴眼镜阈值，取值范围[0,1]
        /// </summary>
        public float wearGlassesThreshold;
    }
}
