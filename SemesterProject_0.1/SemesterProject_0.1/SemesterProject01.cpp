// SemesterProject01.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
//COMMIT BY JUHA 3rd try
//COMMIT BY TOBI

#include <iostream>
#include "opencv2/highgui/highgui.hpp"
#include "opencv2/imgproc/imgproc.hpp"
#include "opencv2/core/core.hpp"
#include "opencv2/opencv.hpp"

using namespace cv;
using namespace std;

int main(int argc, char** argv)
{
	VideoCapture cap(0); //Capture the video from web cam

	if (!cap.isOpened())  //If cannot open wwebcam, exit
	{
		cout << "Cannot open the web cam" << endl;
		return -1;
	}


	while (true)
	{
		Mat imgOriginal;
		Mat imgBlurred;

		bool bSuccess = cap.read(imgOriginal); // Capture frame from the video

		if (!bSuccess) //if not success, break loop
		{
			cout << "Cannot read a frame from video stream" << endl;
			break;
		}

		Mat imgRedOutput;

		inRange(imgOriginal, Scalar(10, 10, 100), Scalar(30, 30, 255), imgRedOutput); //Thresholding, should be a better way to separate the red


		imshow("Original", imgOriginal); //Show the original image
		imshow("Red", imgRedOutput); //Show the image capturing red


		if (waitKey(30) == 27) //wait for 'esc' key press for 30ms. If 'esc' key is pressed, break loop
		{
			cout << "esc key is pressed by user" << endl;
			break;
		}
	}

	return 0;

}

