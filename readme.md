# :file_folder: Filenames Lister

Filenames Lister is a small Windows utility that generates a filenames list from all the files within a directory.
The output list is presented as a [YAML](https://github.com/yaml) file.

![screenshot](./screenshot.jpg?raw=true "Filename Lister")

## :information_source: What it does ?
- It takes as input a directory and Search it for files including its sub-directories .
- Makes a YAML file containing a list of the safe file-names found in the input directory.
- If a file is within a sub-directory of the input directory it will be listed with the sub-directory name.

## :bulb: Example
### :file_folder: Source Folder Structure:
```
:open_file_folder: source_folder
│   :art: art.jpg
│   :book: book.pdf
└───:open_file_folder: food
    │   :cake: cake.html
    ├───:open_file_folder: fruits
    │       :banana: banana.css
    └───:open_file_folder: drinks
            :coffee: coffee.js
```
### :scroll: YAML Output File:
```
---
- art
- book
- food/cake
- food/fruits/banana
- food/drinks/coffee
```

## :information_source: Why I made this ?
I made this for a frontend website that needs to fetch data (via ajax) from many local YAML files that are organized into many directories.
As the website is frontend-only without any backend code, the location (url) of every single one of the files must be picked manually to fully fetch all the needed data.
If the website had a backend, I could simply just write a code that reads the directory containing all the files, list all their locations (urls), or even better, merge them all into one file and sent it to the client. But, there's no backend. All should rely on the client.
So, for simplifying the work, I just need to create a new local YAML file listing all the locations (urls) of the YAML data files. This is what this tool is for, to generate this file automaticly, so everytime I add or update the YAML data files, I just have to run this tool to generate the new list and save it as a YAML file. This list will be fetched by the client, and from it will be able to get all the YAML data files and fetch the full data.