using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateGameObjects : MonoBehaviour {

    private List<double> grid4x4Lat, grid5x5Lat, grid8x8Lat, grid10x10Lat;
    private List<double> grid20x20Lat, grid30x30Lat, grid40x40Lat, grid50x50Lat;
    private List<double> grid60x60Lat, grid70x70Lat, grid80x80Lat, grid100x100Lat;

    private List<double> grid4x4Lon, grid5x5Lon, grid8x8Lon, grid10x10Lon;
    private List<double> grid20x20Lon, grid30x30Lon, grid40x40Lon, grid50x50Lon;
    private List<double> grid60x60Lon, grid70x70Lon, grid80x80Lon, grid100x100Lon;

    private List<double> temps4x4, temps5x5, temps8x8, temps10x10;
    private List<double> temps20x20, temps30x30, temps40x40, temps50x50;
    private List<double> temps60x60, temps70x70, temps80x80, temps100x100;

    private List<GameObject> currentGrid = new List<GameObject>();

    private Color objectColor;
    private ReadTxtFiles txtFile;
    private bool gridAlreadyExist = false;
    private string tempTag = "Temp";

    public Terrain heightMapTerrain;
    public GameObject gridOptionsMenu, selectGridColorMenu;
    public GameObject gridOptionsButton,hideButton,clearButton,showButton,escapeMenuText;

    void Start () {

        GameObject gameObjectTxtFile = new GameObject("ReadTxtFiles");
        txtFile = gameObjectTxtFile.AddComponent<ReadTxtFiles>();

        // Read lat and lon files.
        grid4x4Lat = txtFile.getGrid4x4Lat();
        grid4x4Lon = txtFile.getGrid4x4Lon();

        grid5x5Lat = txtFile.getGrid5x5Lat();
        grid5x5Lon = txtFile.getGrid5x5Lon();

        grid8x8Lat = txtFile.getGrid8x8Lat();
        grid8x8Lon = txtFile.getGrid8x8Lon();

        grid10x10Lat = txtFile.getGrid10x10Lat();
        grid10x10Lon = txtFile.getGrid10x10Lon();

        grid20x20Lat = txtFile.getGrid20x20Lat();
        grid20x20Lon = txtFile.getGrid20x20Lon();

        grid30x30Lat = txtFile.getGrid30x30Lat();
        grid30x30Lon = txtFile.getGrid30x30Lon();

        grid40x40Lat = txtFile.getGrid40x40Lat();
        grid40x40Lon = txtFile.getGrid40x40Lon();

        grid50x50Lat = txtFile.getGrid50x50Lat();
        grid50x50Lon = txtFile.getGrid50x50Lon();

        grid60x60Lat = txtFile.getGrid60x60Lat();
        grid60x60Lon = txtFile.getGrid60x60Lon();

        grid70x70Lat = txtFile.getGrid70x70Lat();
        grid70x70Lon = txtFile.getGrid70x70Lon();

        grid80x80Lat = txtFile.getGrid80x80Lat();
        grid80x80Lon = txtFile.getGrid80x80Lon();

        grid100x100Lat = txtFile.getGrid100x100Lat();
        grid100x100Lon = txtFile.getGrid100x100Lon();

        // Read the temperatures files.
        temps4x4 = txtFile.getTemps4x4();
        temps5x5 = txtFile.getTemps5x5();
        temps8x8 = txtFile.getTemps8x8();
        temps10x10 = txtFile.getTemps10x10();
        temps20x20 = txtFile.getTemps20x20();
        temps30x30 = txtFile.getTemps30x30();
        temps40x40 = txtFile.getTemps40x40();
        temps50x50 = txtFile.getTemps50x50();
        temps60x60 = txtFile.getTemps60x60();
        temps70x70 = txtFile.getTemps70x70();
        temps80x80 = txtFile.getTemps80x80();
        temps100x100 = txtFile.getTemps100x100();

        GameObject.Destroy(gameObjectTxtFile);

    }

    public void CreateGrid4x4()
    {
        BackFromGridOptionsMenu();
        CreateGrid(grid4x4Lat,grid4x4Lon,temps4x4,1,15f);
    }

    public void CreateGrid5x5()
    {
        BackFromGridOptionsMenu();
        CreateGrid(grid5x5Lat, grid5x5Lon, temps5x5,1,15f);
    }

    public void CreateGrid8x8()
    {
        BackFromGridOptionsMenu();
        CreateGrid(grid8x8Lat, grid8x8Lon, temps8x8,1,15f);
    }

    public void CreateGrid10x10()
    {
        BackFromGridOptionsMenu();
        CreateGrid(grid10x10Lat, grid10x10Lon, temps10x10,1,15f);
    }

    public void CreateGrid20x20()
    {
        BackFromGridOptionsMenu();
        CreateGrid(grid20x20Lat, grid20x20Lon, temps20x20,2,6.5f);
    }

    public void CreateGrid30x30()
    {
        BackFromGridOptionsMenu();
        CreateGrid(grid30x30Lat, grid30x30Lon, temps30x30,2,6.5f);
    }

    public void CreateGrid40x40()
    {
        BackFromGridOptionsMenu();
        CreateGrid(grid40x40Lat, grid40x40Lon, temps40x40,2,6.5f);
    }

    public void CreateGrid50x50()
    {
        BackFromGridOptionsMenu();
        CreateGrid(grid50x50Lat, grid50x50Lon, temps50x50,2,6.5f);
    }

    public void CreateGrid60x60()
    {
        BackFromGridOptionsMenu();
        CreateGrid(grid60x60Lat, grid60x60Lon, temps60x60,3,4.8f);
    }

    public void CreateGrid70x70()
    {
        BackFromGridOptionsMenu();
        CreateGrid(grid70x70Lat, grid70x70Lon, temps70x70,3,4.8f);
    }

    public void CreateGrid80x80()
    {
        BackFromGridOptionsMenu();
        CreateGrid(grid80x80Lat, grid80x80Lon, temps80x80,3,4.8f);
    }

    public void CreateGrid100x100()
    {
        BackFromGridOptionsMenu();
        CreateGrid(grid100x100Lat, grid100x100Lon, temps100x100,3,4.8f);
    }

    public void CreateGrid(List<double> latList, List<double> lonList, List<double> tempsList, int gridType, float gridScale)
    {
        int tempsIndex = 0;

        if (gridAlreadyExist == true)
        {
            DestroyGrid();
        }

        for (int i = 0; i < latList.Count; i++)
        {
            for (int j = 0; j < lonList.Count; j++)
            {
                if (gridType == 1) // if this var is 1 create crid with cylinders (red color).
                {
                    GameObject cyl = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

                    cyl.transform.position = new Vector3((float)lonList.ElementAt(j), 0f, (float)latList.ElementAt(i));

                    if (tempsList.ElementAt(tempsIndex) >= 0 && tempsList.ElementAt(tempsIndex) <= 13)
                    {
                        cyl.transform.localScale = new Vector3(gridScale, 50f + (float)tempsList.ElementAt(tempsIndex), gridScale);
                    }
                    else if (tempsList.ElementAt(tempsIndex) > 13 && tempsList.ElementAt(tempsIndex) <= 20)
                    {
                        cyl.transform.localScale = new Vector3(gridScale, 80f + (float)tempsList.ElementAt(tempsIndex), gridScale);
                    }
                    else if (tempsList.ElementAt(tempsIndex) > 20)
                    {
                        cyl.transform.localScale = new Vector3(gridScale, 100f + (float)tempsList.ElementAt(tempsIndex) - 13f, gridScale);
                    }

                    ColorGrid(1f, 0f, 0f, 0f);
                    cyl.tag = tempTag;
                    cyl.GetComponent<Renderer>().material.color = objectColor;
                    currentGrid.Add(cyl);
                    tempsIndex++;


                }
                else if (gridType == 2) // if is 2 create crid with cubes (green color).
                {
                    GameObject cub = GameObject.CreatePrimitive(PrimitiveType.Cube);

                    cub.transform.position = new Vector3((float)lonList.ElementAt(j), 0f, (float)latList.ElementAt(i));

                    if (tempsList.ElementAt(tempsIndex) >= 0 && tempsList.ElementAt(tempsIndex) <= 13)
                    {
                        cub.transform.localScale = new Vector3(gridScale, 90f + (float)tempsList.ElementAt(tempsIndex), gridScale);
                    }
                    else if (tempsList.ElementAt(tempsIndex) > 13 && tempsList.ElementAt(tempsIndex) <= 20)
                    {
                        cub.transform.localScale = new Vector3(gridScale, 180f + (float)tempsList.ElementAt(tempsIndex), gridScale);
                    }
                    else if (tempsList.ElementAt(tempsIndex) > 20)
                    {
                        cub.transform.localScale = new Vector3(gridScale, 250f + (float)tempsList.ElementAt(tempsIndex) - 13f, gridScale);
                    }

                    ColorGrid(0f, 1f, 0f, 0f);
                    cub.tag = tempTag;
                    cub.GetComponent<Renderer>().material.color = objectColor;
                    currentGrid.Add(cub);
                    tempsIndex++;
                }
                else if (gridType == 3) // if is 3 create crid with capsules (blue color).
                {
                    GameObject cap = GameObject.CreatePrimitive(PrimitiveType.Capsule);

                    cap.transform.position = new Vector3((float)lonList.ElementAt(j), 0f, (float)latList.ElementAt(i));

                    if (tempsList.ElementAt(tempsIndex) >= 0 && tempsList.ElementAt(tempsIndex) <= 13)
                    {
                        cap.transform.localScale = new Vector3(gridScale, 35f + (float)tempsList.ElementAt(tempsIndex), gridScale);
                    }
                    else if (tempsList.ElementAt(tempsIndex) > 13 && tempsList.ElementAt(tempsIndex) <= 20)
                    {
                        cap.transform.localScale = new Vector3(gridScale, 65f + (float)tempsList.ElementAt(tempsIndex), gridScale);
                    }
                    else if (tempsList.ElementAt(tempsIndex) > 20)
                    {
                        cap.transform.localScale = new Vector3(gridScale, 90f  + (float)tempsList.ElementAt(tempsIndex) - 13f, gridScale);
                    }

                    ColorGrid(0f, 0f, 1f, 0f);
                    cap.tag = tempTag;
                    cap.GetComponent<Renderer>().material.color = objectColor;
                    currentGrid.Add(cap);
                    tempsIndex++;
                }
            }
        }

        gridAlreadyExist = true;

    }

    public void DestroyGrid()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(tempTag);
        foreach (GameObject target in gameObjects)
        {
            GameObject.Destroy(target);
        }
    }

    public void GridOptionsButtonClicked()
    {
        gridOptionsMenu.SetActive(true);
        gridOptionsButton.SetActive(false);
        clearButton.SetActive(false);
        hideButton.SetActive(false);
        escapeMenuText.SetActive(false);
    }

    public void BackFromGridOptionsMenu()
    {
        gridOptionsMenu.SetActive(false);
        gridOptionsButton.SetActive(true);
        clearButton.SetActive(true);
        hideButton.SetActive(true);
        escapeMenuText.SetActive(true);
    }

    
    public void ClearButtonClicked()
    {
        DestroyGrid();
    }

    public void HideButtonClicked()
    {
        gridOptionsButton.SetActive(false);
        hideButton.SetActive(false);
        clearButton.SetActive(false);
        escapeMenuText.SetActive(false);
        showButton.SetActive(true);
    }

    public void ShowButtonClicked()
    {
        gridOptionsButton.SetActive(true);
        hideButton.SetActive(true);
        clearButton.SetActive(true);
        escapeMenuText.SetActive(true);
        showButton.SetActive(false);
    }

    public void ColorGrid(float r, float g, float b, float a)
    {
        objectColor.r = r;
        objectColor.g = g;
        objectColor.b = b;
        objectColor.a = a;
    }
}