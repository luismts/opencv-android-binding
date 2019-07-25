using Android.Runtime;
using System;
using System.Runtime.InteropServices;
using OpenCV.CoreNET;

namespace OpenCV.SDKDemo.FaceDetect
{
    public class DetectionBasedTracker
    {
        private IntPtr mNativeObj = IntPtr.Zero;

        public DetectionBasedTracker(string cascadeName, int minFaceSize)
        {
            Java.Lang.String s = new Java.Lang.String(cascadeName);
            mNativeObj = nativeCreateObject(JNIEnv.Handle, JNIEnv.FindClass(typeof(Java.Lang.Object)), s.Handle, minFaceSize);
        }

        public void start()
        {
            nativeStart(JNIEnv.Handle, JNIEnv.FindClass(typeof(Java.Lang.Object)), mNativeObj);
        }

        public void stop()
        {
            nativeStop(JNIEnv.Handle, JNIEnv.FindClass(typeof(Java.Lang.Object)), mNativeObj);
        }

        public void setMinFaceSize(int size)
        {
            nativeSetFaceSize(JNIEnv.Handle, JNIEnv.FindClass(typeof(Java.Lang.Object)), mNativeObj, size);
        }

        public void detect(Mat imageGray, MatOfRect faces)
        {
            nativeDetect(JNIEnv.Handle, JNIEnv.FindClass(typeof(Java.Lang.Object)), mNativeObj, imageGray.NativeObjAddr, faces.NativeObjAddr);
        }

        public void release()
        {
            nativeDestroyObject(JNIEnv.Handle, JNIEnv.FindClass(typeof(Java.Lang.Object)), mNativeObj);
            mNativeObj = IntPtr.Zero;
        }

        [DllImport("libdetection_based_tracker", EntryPoint = "Java_org_opencv_samples_facedetect_DetectionBasedTracker_nativeCreateObject")]
        private static extern IntPtr nativeCreateObject(IntPtr env, IntPtr jniClass, IntPtr cascadeName, int minFaceSize);

        [DllImport("libdetection_based_tracker", EntryPoint = "Java_org_opencv_samples_facedetect_DetectionBasedTracker_nativeDestroyObject")]
        private static extern void nativeDestroyObject(IntPtr env, IntPtr jniClass, IntPtr thiz);

        [DllImport("libdetection_based_tracker", EntryPoint = "Java_org_opencv_samples_facedetect_DetectionBasedTracker_nativeStart")]
        private static extern void nativeStart(IntPtr env, IntPtr jniClass, IntPtr thiz);

        [DllImport("libdetection_based_tracker", EntryPoint = "Java_org_opencv_samples_facedetect_DetectionBasedTracker_nativeStop")]
        private static extern void nativeStop(IntPtr env, IntPtr jniClass, IntPtr thiz);

        [DllImport("libdetection_based_tracker", EntryPoint = "Java_org_opencv_samples_facedetect_DetectionBasedTracker_nativeSetFaceSize")]
        private static extern void nativeSetFaceSize(IntPtr env, IntPtr jniClass, IntPtr thiz, int size);

        [DllImport("libdetection_based_tracker", EntryPoint = "Java_org_opencv_samples_facedetect_DetectionBasedTracker_nativeDetect")]
        private static extern void nativeDetect(IntPtr env, IntPtr jniClass, IntPtr thiz, long inputImage, long faces);
    }
}