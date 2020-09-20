<?
$var = 1;
$var1= "test";
$var2 = 1.2345678900000000009999997;
$var3=true;
p($var.$var1.$var2.$var3);

for($i=0;$i<9;$i++){
  p($i);
}

function p($var){
  echo $var."<br>";
}

$j=1;
while($j<=10){
  p($j);
  $j++;
}

$s="333";
switch($s){
  case "333":
  p(123);
  break;
  case "123455":
  p(333);
}

$arr=array(1,3,5,7,9);
foreach ($arr as $val){
  p($val);
}

if(true){
  p(null."123");
}else{
  p(null);
}

$k=1;
do{
  p(987654321);
  $k++;
}while($k<=10);

class Test{

function test(){
 p("test");
}

}

$test=new Test();
//$test->test();

/*
 * text..........
 * Ttttt
 * 
 * 
 * 
 */