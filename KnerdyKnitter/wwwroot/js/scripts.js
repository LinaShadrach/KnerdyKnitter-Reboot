$(document).ready(function () {
    var primaryColor = $("#primaryColor").val();
    var secondaryColor = $("#secondaryColor").val();
    changeColors();
});

function changeColors(){
  changePrimaryColor();
  changeSecondaryColor();
}

function changeDimensions(){
  drawScarf($("#rule").val());
}

function getRule(){
  return $("#rule").val();
}

function getWidth(){
  return $("#width").val();
}
function getLength(){
  return $("#length").val();
}

function changePrimaryColor() {
  var primaryColor = $("#primaryColor").val();
  $(".primary").css("fill", primaryColor);
}

function changeSecondaryColor() {
  var secondaryColor = $("#secondaryColor").val();
  $(".secondary").css("fill", secondaryColor);
}

function changeRule() {
  var rule = changeRuleToBinaryArray(getRule());
  drawScarf(rule);
}

function drawScarf(rule) {
  var width = parseInt(getWidth()) * 20;
  var height = parseInt(getLength()) * 20;
  var scarfSvg = "<svg class='scarf' width='" + width + "' height='" + height + "'>";
  var creation = createScarfBinary(rule);
  var x = 0;
  var y = 0;
  var sideSize = 20;
  creation.forEach(function(row) {
    row.forEach(function(cell) {
      scarfSvg += "<rect id='' x='"+x+"' y='"+y+"' width='" + sideSize + "' height='" + sideSize + "' class='cell ";
      if(cell===0){
        scarfSvg += "primary'/>";
      }
      else {
        scarfSvg += "secondary'/>";
      }
      x+=sideSize;
    });
    x=0;
    y+=sideSize;
  });
  scarfSvg += "</svg>";
  $(".scarf-container").empty();
  $(".scarf-container").append(scarfSvg);
  changeColors();
}

function changeRuleToBinaryArray(rule) {
  rule = parseInt(rule).toString(2);
  var originalLength=rule.length;
  if(originalLength<8) {
    for(var i=0; i<8-originalLength; i++) {
      rule="0"+rule;
    }
  }
  rule = rule.split("");
  return rule;
}

function createScarfBinary(rule) {
  var length = getLength();
  var creation = [[]];
  var column = 0;
  var baseRow = createBaseRow();
  baseRow.forEach(function(cell) {
    creation[0].push(cell);
  })
  for(var row = 1; row < length; row++) {
    creation[row]=[];
    for(var column = 0; column < baseRow.length; column++) {
      if(column === 0){
        creation[row].push(getCell([creation[row-1][baseRow.length - 1], creation[row-1][column], creation[row-1][column+1]], rule));
      }
      else if (column===baseRow.length-1) {
        creation[row].push(getCell([creation[row-1][column-1], creation[row - 1][column], creation[row - 1][0]], rule));
      }
      else{
        creation[row].push(getCell([creation[row-1][column-1], creation[row- 1][column], creation[row-1][column+1]], rule));
      }
    }
  }
  return creation;
}

function createBaseRow() {
  var baseRow = [];
  var width = getWidth();
  for(var i = 0; i < width; i++) {
    if(i === Math.round(width/2)) {
      baseRow.push(1);
    }
    else {
      baseRow.push(0);
    }
  }
  return baseRow;
}
function getCell(parentCells) {
  var position = parseInt(parentCells.join(""), 2);
  var rule = getRule();
  var binaryRule = changeRuleToBinaryArray(rule);
  var reversedRule = binaryRule.slice(0, binaryRule.length).reverse();
  return parseInt(reversedRule[position]);
}
