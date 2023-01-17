// See https://aka.ms/new-console-template for more information


using System.Text.Json;
using Anthony.Quere.FaceDetection;


var imagesBytes = new List<byte[]>();

foreach (var arg in args)
{
    imagesBytes.Add(await File.ReadAllBytesAsync(arg));
}

var detectFaceInScenesResults = new FaceDetection().DetectInScenes(imagesBytes);

foreach (var detectionResult in detectFaceInScenesResults)
{
    System.Console.WriteLine($"Points:{JsonSerializer.Serialize(detectionResult.Points)}");
} 
