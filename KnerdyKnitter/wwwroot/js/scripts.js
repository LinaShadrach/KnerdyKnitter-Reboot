$(document).ready(function () {
    var primaryColor = $("#primaryColor").val();
    var secondaryColor = $("#secondaryColor").val();
    changeColors();
});

function changeColors(){
  changePrimaryColor();
  changeSecondaryColor();
}

function changePrimaryColor() {
  var primaryColor = $("#primaryColor").val();
  $(".primary").css("fill", primaryColor);
}

function changeSecondaryColor() {
  var secondaryColor = $("#secondaryColor").val();
  $(".secondary").css("fill", secondaryColor);
}

function changeRule(rule) {
  rule = changeRuleToBinaryArray(rule);
  drawScarf(rule);
}

function drawScarf(rule) {
  var scarfSvg = "<svg class='scarf' width='200' height='2000'>";
  var baseRow = [0, 0, 0, 0, 0, 1, 0, 0, 0, 0];
  var creation = createScarfBinary(baseRow, rule);
  var x = 0;
  var y = 0;
  creation.forEach(function(row) {
    row.forEach(function(cell) {
      if(cell===0){
        scarfSvg += "<rect id='' x='"+x+"' y='"+y+"' width='20' height='20' class='primary cell' />";
      }
      else {
        scarfSvg += "<rect id='' x='"+x+"' y='"+y+"' width='20' height='20' class='secondary cell' />";
      }
      x+=20;
    });
    x=0;
    y+=20;
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

function createScarfBinary(baseRow, rule) {
  var creation = [[]];
  var column = 0;
  baseRow.forEach(function(cell) {
    creation[0].push(cell);
  })
  for(var row=1; row<100; row++) {
    creation[row]=[];
    for(var column=0; column<baseRow.length; column++) {
      if(column===0){
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

function getCell(parentCells, rule) {
  var position = parseInt(parentCells.join(""), 2);
  var reversedRule = rule.slice().reverse();
  return parseInt(reversedRule[position]);
}
