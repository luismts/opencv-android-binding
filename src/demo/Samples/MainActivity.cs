using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
using OpenCV.CoreNET;
using OpenCV.Features2dNET;
using OpenCV.SDKDemo.CameraCalibration;
using OpenCV.SDKDemo.CameraControl;
using OpenCV.SDKDemo.CameraPreview;
using OpenCV.SDKDemo.ColorBlobDetection;
using OpenCV.SDKDemo.FaceDetect;
using OpenCV.SDKDemo.ImageManipulations;
using OpenCV.SDKDemo.MixedProcessing;
using OpenCV.SDKDemo.Puzzle;

namespace OpenCV.SDKDemo
{
    [Activity(Label = "OpenCV.SDKDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            FindViewById<Button>(Resource.Id.cameraPreview)
                .Click += (s, e) => StartActivity(typeof(CameraPreviewActivity));

            FindViewById<Button>(Resource.Id.mixedProcessing)
                .Click += (s, e) => StartActivity(typeof(MixedProcessingActivity));

            FindViewById<Button>(Resource.Id.cameraControl)
                .Click += (s, e) => StartActivity(typeof(CameraControlActivity));

            FindViewById<Button>(Resource.Id.imageManipulations)
                .Click += (s, e) => StartActivity(typeof(ImageManipulationsActivity));

            FindViewById<Button>(Resource.Id.faceDetection)
                .Click += (s, e) => StartActivity(typeof(FaceDetectActivity));

            FindViewById<Button>(Resource.Id.colorBlobDetection)
                .Click += (s, e) => StartActivity(typeof(ColorBlobDetectionActivity));

            FindViewById<Button>(Resource.Id.cameraCalibration)
                .Click += (s, e) => StartActivity(typeof(CameraCalibrationActivity));

            FindViewById<Button>(Resource.Id.puzzle)
                .Click += (s, e) => StartActivity(typeof(PuzzleActivity));

            //Search();
        }


        public void Search()
        {
            //Mat src = new Mat(image, ImreadModes.Color);
            //Mat patt = new Mat(tpath, ImreadModes.Color);           

           // Mat src = new Mat();
         //   Mat patt = new Mat(); // ConvertToMat(_fragment); // _key.Image;
           // Cv2.ImWrite(@"F:\Project\Mpie\Doc\mobile\MKey.png", patt);
            
            //var surf = SURF.Create(500);

            //var desc = new Mat();
            //var keyPoints = surf.Detect(patt);
            //surf.Compute(patt, ref keyPoints, desc);


            //var des_src = new Mat();
            //var keyPoints_src = surf.Detect(src);
            //surf.Compute(src, ref keyPoints_src, des_src);

            //var bfMatcher = new BFMatcher();
            //var matches = bfMatcher.KnnMatch(desc, des_src, 2);

            //var good_matches = new List<DMatch>();

            //for (int i = 0; i < Math.Min(des_src.Rows - 1, (int)matches.Count()); i++) //THIS LOOP IS SENSITIVE TO SEGFAULTS
            //{
            //    var distance = (matches[i][0].Distance < 0.6 * (matches[i][1].Distance));
            //    var count = ((int)matches[i].Count() <= 2 && (int)matches[i].Count() > 0);
            //    if (distance && count)
            //    {
            //        good_matches.Add(matches[i][0]);


            //    }
            //}

            ////Mat matches_image = new Mat();

            //Cv2.PutText(src, good_matches.Count.ToString(), new OpenCvSharp.Point(0, 0), HersheyFonts.HersheySimplex, 1, new Scalar(0, 200, 200), 4);

            //if (good_matches.Count < 5)
            //    return;

            //Mat matches_image = new Mat();
            //Cv2.DrawMatches(patt, keyPoints, src, keyPoints_src, good_matches, matches_image); // Íàðèñîâàòü ïîèñêîâûå ëèíèè
            //Cv2.ImShow("drm", matches_image);

            //var qm = good_matches.Select(gm => keyPoints[gm.QueryIdx].Pt).ToArray();
            //var tr = good_matches.Select(gm => keyPoints_src[gm.TrainIdx].Pt).ToArray();

            //var query = InputArray.Create(qm);
            //var train = InputArray.Create(tr);

            //Point2f[] obj_corners = new Point2f[4];

            ////Get the corners from the object
            //obj_corners[0] = new Point2f(0, 0);
            //obj_corners[1] = new Point2f(patt.Cols, 0);
            //obj_corners[2] = new Point2f(patt.Cols, patt.Rows);
            //obj_corners[3] = new Point2f(0, patt.Rows);


            //var homography = Cv2.FindHomography(query, train, HomographyMethods.Ransac);
            //var scene_corners = Cv2.PerspectiveTransform(obj_corners, homography);

            //Point[] task = new Point[4];


            //Point pt1 = (Point)(scene_corners[0]); //  + new Point2f(patt.Cols, 0)
            //Point pt2 = (Point)(scene_corners[1]); //  + new Point2f(patt.Cols, 0)
            //task[0] = pt1;
            //Cv2.Line(src, pt1, pt2, new Scalar(0, 255, 0), 4);

            //pt1 = (Point)(scene_corners[1]); //  + new Point2f(patt.Cols, 0)
            //pt2 = (OpenCvSharp.Point)(scene_corners[2]); //  + new Point2f(patt.Cols, 0)
            //task[1] = pt1;
            //Cv2.Line(src, pt1, pt2, new Scalar(0, 255, 0), 4);

            //pt1 = (OpenCvSharp.Point)(scene_corners[2]); //  + new Point2f(patt.Cols, 0)
            //pt2 = (OpenCvSharp.Point)(scene_corners[3]); //  + new Point2f(patt.Cols, 0)
            //task[2] = pt1;
            //Cv2.Line(src, pt1, pt2, new Scalar(0, 255, 0), 4);

            //pt1 = (OpenCvSharp.Point)(scene_corners[3]); //  + new Point2f(patt.Cols, 0)
            //pt2 = (OpenCvSharp.Point)(scene_corners[0]); //  + new Point2f(patt.Cols, 0)
            //task[3] = pt1;
            //Cv2.Line(src, pt1, pt2, new Scalar(0, 255, 0), 4);

            //Cv2.ImShow("src", src);

        }
    }
}

