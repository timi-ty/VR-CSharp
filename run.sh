#!/bin/bash
mcs -out:main.exe SceneDataAccesor.cs DataObject.cs
mono main.exe