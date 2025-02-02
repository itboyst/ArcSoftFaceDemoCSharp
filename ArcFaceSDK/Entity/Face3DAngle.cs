﻿namespace ArcFaceSDK.Entity
{
    /// <summary>
    /// 3D人脸角度检测结构体
    /// </summary>
    public class Face3DAngle
    {
        /// <summary>
        /// 横滚角
        /// </summary>
        public float[] roll { get; set; }

        /// <summary>
        /// 偏航角
        /// </summary>
        public float[] yaw { get; set; }

        /// <summary>
        /// 俯仰角
        /// </summary>
        public float[] pitch { get; set; }
    }
}
