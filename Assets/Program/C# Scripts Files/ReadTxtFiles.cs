using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ReadTxtFiles : MonoBehaviour {

    private List<double> grid4x4Lat, grid5x5Lat, grid8x8Lat, grid10x10Lat;
    private List<double> grid20x20Lat, grid30x30Lat, grid40x40Lat, grid50x50Lat;
    private List<double> grid60x60Lat, grid70x70Lat, grid80x80Lat, grid100x100Lat;

    private List<double> grid4x4Lon, grid5x5Lon, grid8x8Lon, grid10x10Lon;
    private List<double> grid20x20Lon, grid30x30Lon, grid40x40Lon, grid50x50Lon;
    private List<double> grid60x60Lon, grid70x70Lon, grid80x80Lon, grid100x100Lon;

    private List<double> grid4x4UnityLat, grid5x5UnityLat, grid8x8UnityLat, grid10x10UnityLat;
    private List<double> grid20x20UnityLat, grid30x30UnityLat, grid40x40UnityLat, grid50x50UnityLat;
    private List<double> grid60x60UnityLat, grid70x70UnityLat, grid80x80UnityLat, grid100x100UnityLat;

    private List<double> grid4x4UnityLon, grid5x5UnityLon, grid8x8UnityLon, grid10x10UnityLon;
    private List<double> grid20x20UnityLon, grid30x30UnityLon, grid40x40UnityLon, grid50x50UnityLon;
    private List<double> grid60x60UnityLon, grid70x70UnityLon, grid80x80UnityLon, grid100x100UnityLon;

    private List<double> temps4x4, temps5x5, temps8x8, temps10x10;
    private List<double> temps20x20, temps30x30, temps40x40, temps50x50;
    private List<double> temps60x60, temps70x70, temps80x80, temps100x100;

    private string myPath = "C:\\Users\\PC-TECH\\Documents\\Unity\\Tutorials\\";

    public ReadTxtFiles()
    {
        /* Paths for the text files. */
        string grid4x4LatFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid4x4Lat.txt";
        string grid4x4LonFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid4x4Lon.txt";

        string grid5x5LatFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid5x5Lat.txt";
        string grid5x5LonFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid5x5Lon.txt";

        string grid8x8LatFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid8x8Lat.txt";
        string grid8x8LonFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid8x8Lon.txt";

        string grid10x10LatFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid10x10Lat.txt";
        string grid10x10LonFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid10x10Lon.txt";

        string grid20x20LatFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid20x20Lat.txt";
        string grid20x20LonFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid20x20Lon.txt";

        string grid30x30LatFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid30x30Lat.txt";
        string grid30x30LonFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid30x30Lon.txt";

        string grid40x40LatFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid40x40Lat.txt";
        string grid40x40LonFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid40x40Lon.txt";

        string grid50x50LatFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid50x50Lat.txt";
        string grid50x50LonFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid50x50Lon.txt";

        string grid60x60LatFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid60x60Lat.txt";
        string grid60x60LonFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid60x60Lon.txt";

        string grid70x70LatFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid70x70Lat.txt";
        string grid70x70LonFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid70x70Lon.txt";

        string grid80x80LatFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid80x80Lat.txt";
        string grid80x80LonFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid80x80Lon.txt";

        string grid100x100LatFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid100x100Lat.txt";
        string grid100x100LonFilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\grid100x100Lon.txt";

        string temps4x4FilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\temps4x4.txt";
        string temps5x5FilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\temps5x5.txt";
        string temps8x8FilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\temps8x8.txt";
        string temps10x10FilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\temps10x10.txt";
        string temps20x20FilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\temps20x20.txt";
        string temps30x30FilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\temps30x30.txt";
        string temps40x40FilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\temps40x40.txt";
        string temps50x50FilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\temps50x50.txt";
        string temps60x60FilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\temps60x60.txt";
        string temps70x70FilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\temps70x70.txt";
        string temps80x80FilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\temps80x80.txt";
        string temps100x100FilePath = myPath + "MainMenu\\Assets\\Program\\Text Files\\temps100x100.txt";

        /* Calling the ReadFile(filePath) method to make lists for the grids. */
        grid4x4Lat = ReadFile(grid4x4LatFilePath);
        grid4x4Lon = ReadFile(grid4x4LonFilePath);

        grid5x5Lat = ReadFile(grid5x5LatFilePath);
        grid5x5Lon = ReadFile(grid5x5LonFilePath);

        grid8x8Lat = ReadFile(grid8x8LatFilePath);
        grid8x8Lon = ReadFile(grid8x8LonFilePath);

        grid10x10Lat = ReadFile(grid10x10LatFilePath);
        grid10x10Lon = ReadFile(grid10x10LonFilePath);

        grid20x20Lat = ReadFile(grid20x20LatFilePath);
        grid20x20Lon = ReadFile(grid20x20LonFilePath);

        grid30x30Lat = ReadFile(grid30x30LatFilePath);
        grid30x30Lon = ReadFile(grid30x30LonFilePath);

        grid40x40Lat = ReadFile(grid40x40LatFilePath);
        grid40x40Lon = ReadFile(grid40x40LonFilePath);

        grid50x50Lat = ReadFile(grid50x50LatFilePath);
        grid50x50Lon = ReadFile(grid50x50LonFilePath);

        grid60x60Lat = ReadFile(grid60x60LatFilePath);
        grid60x60Lon = ReadFile(grid60x60LonFilePath);

        grid70x70Lat = ReadFile(grid70x70LatFilePath);
        grid70x70Lon = ReadFile(grid70x70LonFilePath);

        grid80x80Lat = ReadFile(grid80x80LatFilePath);
        grid80x80Lon = ReadFile(grid80x80LonFilePath);

        grid100x100Lat = ReadFile(grid100x100LatFilePath);
        grid100x100Lon = ReadFile(grid100x100LonFilePath);

        /* Calling the ReadFile(filePath) method to make lists for the temps. */
        temps4x4 = ReadFile(temps4x4FilePath);
        temps5x5 = ReadFile(temps5x5FilePath);
        temps8x8 = ReadFile(temps8x8FilePath);
        temps10x10 = ReadFile(temps10x10FilePath);
        temps20x20 = ReadFile(temps20x20FilePath);
        temps30x30 = ReadFile(temps30x30FilePath);
        temps40x40 = ReadFile(temps40x40FilePath);
        temps50x50 = ReadFile(temps50x50FilePath);
        temps60x60 = ReadFile(temps60x60FilePath);
        temps70x70 = ReadFile(temps70x70FilePath);
        temps80x80 = ReadFile(temps80x80FilePath);
        temps100x100 = ReadFile(temps100x100FilePath);

        /* Remove the last element of each lists because it was zero. */
        grid4x4Lat.RemoveAt(grid4x4Lat.Count-1);
        grid4x4Lon.RemoveAt(grid4x4Lon.Count-1);

        grid5x5Lat.RemoveAt(grid5x5Lat.Count-1);
        grid5x5Lon.RemoveAt(grid5x5Lon.Count-1);

        grid8x8Lat.RemoveAt(grid8x8Lat.Count-1);
        grid8x8Lon.RemoveAt(grid8x8Lon.Count-1);

        grid10x10Lat.RemoveAt(grid10x10Lat.Count-1);
        grid10x10Lon.RemoveAt(grid10x10Lon.Count-1);

        temps4x4.RemoveAt(temps4x4.Count-1);
        temps5x5.RemoveAt(temps5x5.Count-1);
        temps8x8.RemoveAt(temps8x8.Count-1);
        temps10x10.RemoveAt(temps10x10.Count-1);

        /* Convert the lat lon coordinates for each grid in Unity coordinates. */
        grid4x4UnityLat = ConvertLatToUnity(grid4x4Lat,175);
        grid4x4UnityLon = ConvertLonToUnity(grid4x4Lon,175);

        grid5x5UnityLat = ConvertLatToUnity(grid5x5Lat,140);
        grid5x5UnityLon = ConvertLonToUnity(grid5x5Lon,140);

        grid8x8UnityLat = ConvertLatToUnity(grid8x8Lat,80);
        grid8x8UnityLon = ConvertLonToUnity(grid8x8Lon,80);

        grid10x10UnityLat = ConvertLatToUnity(grid10x10Lat,62);
        grid10x10UnityLon = ConvertLonToUnity(grid10x10Lon,62);

        grid20x20UnityLat = ConvertLatToUnity(grid20x20Lat,30);
        grid20x20UnityLon = ConvertLonToUnity(grid20x20Lon,30);

        grid30x30UnityLat = ConvertLatToUnity(grid30x30Lat,19);
        grid30x30UnityLon = ConvertLonToUnity(grid30x30Lon,19);

        grid40x40UnityLat = ConvertLatToUnity(grid40x40Lat,14);
        grid40x40UnityLon = ConvertLonToUnity(grid40x40Lon,14);

        grid50x50UnityLat = ConvertLatToUnity(grid50x50Lat, 12);
        grid50x50UnityLon = ConvertLonToUnity(grid50x50Lon, 12);

        grid60x60UnityLat = ConvertLatToUnity(grid60x60Lat, 9.2);
        grid60x60UnityLon = ConvertLonToUnity(grid60x60Lon, 9.2);

        grid70x70UnityLat = ConvertLatToUnity(grid70x70Lat, 8);
        grid70x70UnityLon = ConvertLonToUnity(grid70x70Lon, 8);

        grid80x80UnityLat = ConvertLatToUnity(grid80x80Lat, 7);
        grid80x80UnityLon = ConvertLonToUnity(grid80x80Lon, 7);

        grid100x100UnityLat = ConvertLatToUnity(grid100x100Lat,5.4);
        grid100x100UnityLon = ConvertLatToUnity(grid100x100Lon,5.4);
    }

    public List<double> ReadFile(string filePath)
    {
        String line;
        double number;
        List<double> list = new List<double>();

        try
        {
            StreamReader sr = new StreamReader(filePath);

            line = sr.ReadLine();

            while (line != null)
            {
                line = sr.ReadLine();
                number = Convert.ToDouble(line);
                list.Add(number);
            }
        }
        catch (Exception e)
        {
            Debug.Log("Exception: " + e.Message);
        }

        return list;
    }

    public List<double> ConvertLatToUnity(List<double> listLat, double space)
    {
        List<double> finalLatList = new List<double>();

        finalLatList.Add(listLat.ElementAt(0));

        for (int i = 1; i < listLat.Count; i++)
        {
            finalLatList.Add(finalLatList.ElementAt(i-1)+space);
        }

        return finalLatList;
    }

    public List<double> ConvertLonToUnity(List<double> listLon, double space)
    {
        List<double> finalLonList = new List<double>();

        finalLonList.Add(listLon.ElementAt(0));

        for (int i = 1; i < listLon.Count; i++)
        {
            finalLonList.Add(finalLonList.ElementAt(i-1)+space);
        }

        return finalLonList;
    }


    /* GRID 4x4 */
    public List<double> getGrid4x4Lat()
    {
        return grid4x4UnityLat;
    }

    public List<double> getGrid4x4Lon()
    {
        return grid4x4UnityLon;
    }


    /* GRID 5x5 */
    public List<double> getGrid5x5Lat()
    {
        return grid5x5UnityLat;
    }

    public List<double> getGrid5x5Lon()
    {
        return grid5x5UnityLon;
    }


    /* GRID 8x8 */
    public List<double> getGrid8x8Lat()
    {
        return grid8x8UnityLat;
    }

    public List<double> getGrid8x8Lon()
    {
        return grid8x8UnityLon;
    }


    /* GRID 10x10 */
    public List<double> getGrid10x10Lat()
    {
        return grid10x10UnityLat;
    }

    public List<double> getGrid10x10Lon()
    {
        return grid10x10UnityLon;
    }

    /* GRID 20x20 */
    public List<double> getGrid20x20Lat()
    {
        return grid20x20UnityLat;
    }

    public List<double> getGrid20x20Lon()
    {
        return grid20x20UnityLon;
    }

    /* GRID 30x30 */
    public List<double> getGrid30x30Lat()
    {
        return grid30x30UnityLat;
    }

    public List<double> getGrid30x30Lon()
    {
        return grid30x30UnityLon;
    }

    /* GRID 40x40 */
    public List<double> getGrid40x40Lat()
    {
        return grid40x40UnityLat;
    }

    public List<double> getGrid40x40Lon()
    {
        return grid40x40UnityLon;
    }

    /* GRID 50x50 */
    public List<double> getGrid50x50Lat()
    {
        return grid50x50UnityLat;
    }

    public List<double> getGrid50x50Lon()
    {
        return grid50x50UnityLon;
    }

    /* GRID 60x60 */
    public List<double> getGrid60x60Lat()
    {
        return grid60x60UnityLat;
    }

    public List<double> getGrid60x60Lon()
    {
        return grid60x60UnityLon;
    }

    /* GRID 70x70 */
    public List<double> getGrid70x70Lat()
    {
        return grid70x70UnityLat;
    }

    public List<double> getGrid70x70Lon()
    {
        return grid70x70UnityLon;
    }

    /* GRID 80x80 */
    public List<double> getGrid80x80Lat()
    {
        return grid80x80UnityLat;
    }

    public List<double> getGrid80x80Lon()
    {
        return grid80x80UnityLon;
    }

    /* GRID 100x100 */
    public List<double> getGrid100x100Lat()
    {
        return grid100x100UnityLat;
    }

    public List<double> getGrid100x100Lon()
    {
        return grid100x100UnityLon;
    }


    /* TEMPERATURES */
    public List<double> getTemps4x4()
    {
        return temps4x4;
    }

    public List<double> getTemps5x5()
    {
        return temps5x5;
    }

    public List<double> getTemps8x8()
    {
        return temps8x8;
    }

    public List<double> getTemps10x10()
    {
        return temps10x10;
    }

    public List<double> getTemps20x20()
    {
        return temps20x20;
    }

    public List<double> getTemps30x30()
    {
        return temps30x30;
    }

    public List<double> getTemps40x40()
    {
        return temps40x40;
    }

    public List<double> getTemps50x50()
    {
        return temps50x50;
    }

    public List<double> getTemps60x60()
    {
        return temps60x60;
    }

    public List<double> getTemps70x70()
    {
        return temps70x70;
    }

    public List<double> getTemps80x80()
    {
        return temps80x80;
    }

    public List<double> getTemps100x100()
    {
        return temps100x100;
    }
}