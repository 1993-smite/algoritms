'use strict';

class File 
{
    readTextFile (path, callback) {
        var rawFile = new XMLHttpRequest();
        rawFile.overrideMimeType("application/json");
        rawFile.open("GET", path, true);
        rawFile.onreadystatechange = function() {
            if (rawFile.readyState === 4 && rawFile.status == "200") {
                let json = JSON.parse(rawFile.responseText);
                if (callback)
                    callback(json);
                else return json;
            }
        }
        rawFile.send(null);
    }

    getDataFromUrl (path){
        let json = require(path);
        return json;
    }

    readingJson(path){
        let jsonData = require(path);
        return JSON.parse(rawdata);
    }
}

export default new File();