"use strict";
// To run:
// (a) > tsc --module commonjs 06-additionModule.ts 
// (b) > tsc 06-app.ts
// (c) > node 06-app.ts
exports.__esModule = true;
var _06_additionModule_1 = require("./06-additionModule");
var addObject = new _06_additionModule_1.Addition(10, 20);
addObject.Sum();
