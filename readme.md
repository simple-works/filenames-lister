# :file_folder: Filenames Lister

[![Plarform Windows](https://img.shields.io/badge/Windows-blue?logo=windows)](https://github.com/topics/windows)
[![C# 4.0](https://img.shields.io/badge/C%23-4.0-blue?logo=c-sharp)](https://github.com/topics/csharp)
[![.NET Framework 4.0](https://img.shields.io/badge/.NET%20Framework-4.0-blue?logo=dot-net)](https://github.com/topics/dotnet)

Filenames Lister is a small Windows utility that generates a filenames list from all the files within a directory.
The output list is presented as a [YAML](https://github.com/yaml) file.

![screenshot](./screenshot.jpg?raw=true "Filename Lister")

## :information_source: What it does ?
- It takes as input a directory and Search it for files including its sub-directories .
- Makes a YAML file containing a list of the safe file-names found in the input directory.
- If a file is within a sub-directory of the input directory it will be listed with the sub-directory name.

## :bulb: Example
#### :file_folder: Source Folder Structure:
```
📂 source_folder
│ 🎨 art.jpg
│ 📖 book.pdf
└───📁 food
    │ 🎂 cake.html
    ├───📁 fruits
    │ 🍌 banana.css
    └───📁 drinks
      ☕ coffee.js
```

#### :scroll: YAML Output File:
```
---
- art
- book
- food/cake
- food/fruits/banana
- food/drinks/coffee
```

## :information_source: Why I made this ?
I made this for a frontend website that needs to fetch data (via ajax) from many local YAML files that are organized into many directories.<br/>
As the website is frontend-only without any backend code, the location (url) of every single one of the files must be picked manually to fully fetch all the needed data.<br/>
If the website had a backend, I could simply just write a code that reads the directory containing all the files, list all their locations (urls), or even better, merge them all into one file and sent it to the client. But, there's no backend. All should rely on the client.<br/>
So, for simplifying the work, I just need to create a new local YAML file listing all the locations (urls) of the YAML data files. This is what this tool is for, to generate this file automaticly, so everytime I add or update the YAML data files, I just have to run this tool to generate the new list and save it as a YAML file. This list will be fetched by the client, and from it will be able to get all the YAML data files and fetch the full data.

## 🚀 Development
The source is written in **[C#](https://github.com/dotnet/csharplang) 4.0** with **[.NET](https://github.com/dotnet) Framework 4.0** and **[WinForms](https://github.com/dotnet/winforms)** using **[Visual Studio](https://visualstudio.microsoft.com) 2010**.

## :page_facing_up: License
- Licensed under the [MIT License](./LICENSE?raw=true).<br/>
- Using [Free FatCow Farm Fresh Icons 3.92](http://www.fatcow.com/free-icons) licensed under the [CC BY 3.0 License](https://creativecommons.org/licenses/by/3.0/us).