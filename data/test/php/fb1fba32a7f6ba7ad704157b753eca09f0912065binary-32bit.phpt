--TEST--
testing binary literals
--INI--
precision=14
--SKIPIF--
<?php if (PHP_INT_SIZE != 4) die("skip this test is for 32bit platform only"); ?>
--FILE--
<?php
var_dump(0b1);
var_dump(0b11);
var_dump(0b111);
var_dump(0b1111);
var_dump(0b11111);
var_dump(0b111111);
var_dump(0b1111111);
var_dump(0b11111111);
var_dump(0b111111111);
var_dump(0b1111111111);
var_dump(0b11111111111);
var_dump(0b111111111111);
var_dump(0b1111111111111);
var_dump(0b11111111111111);
var_dump(0b111111111111111);
var_dump(0b1111111111111111);
var_dump(0b11111111111111111);
var_dump(0b111111111111111111);
var_dump(0b1111111111111111111);
var_dump(0b11111111111111111111);
var_dump(0b111111111111111111111);
var_dump(0b1111111111111111111111);
var_dump(0b11111111111111111111111);
var_dump(0b111111111111111111111111);
var_dump(0b1111111111111111111111111);
var_dump(0b11111111111111111111111111);
var_dump(0b111111111111111111111111111);
var_dump(0b1111111111111111111111111111);
var_dump(0b11111111111111111111111111111);
var_dump(0b111111111111111111111111111111);
var_dump(0b1111111111111111111111111111111);
var_dump(0b11111111111111111111111111111111);
var_dump(0b111111111111111111111111111111111);
var_dump(0b1111111111111111111111111111111111);
var_dump(0b11111111111111111111111111111111111);
var_dump(0b111111111111111111111111111111111111);
var_dump(0b1111111111111111111111111111111111111);
var_dump(0b11111111111111111111111111111111111111);
var_dump(0b111111111111111111111111111111111111111);
var_dump(0b1111111111111111111111111111111111111111);
var_dump(0b11111111111111111111111111111111111111111);
var_dump(0b111111111111111111111111111111111111111111);
var_dump(0b1111111111111111111111111111111111111111111);
var_dump(0b11111111111111111111111111111111111111111111);
var_dump(0b111111111111111111111111111111111111111111111);
var_dump(0b1111111111111111111111111111111111111111111111);
var_dump(0b11111111111111111111111111111111111111111111111);
var_dump(0b111111111111111111111111111111111111111111111111);
var_dump(0b1111111111111111111111111111111111111111111111111);
var_dump(0b11111111111111111111111111111111111111111111111111);
var_dump(0b111111111111111111111111111111111111111111111111111);
var_dump(0b1111111111111111111111111111111111111111111111111111);
var_dump(0b11111111111111111111111111111111111111111111111111111);
var_dump(0b111111111111111111111111111111111111111111111111111111);
var_dump(0b1111111111111111111111111111111111111111111111111111111);
var_dump(0b11111111111111111111111111111111111111111111111111111111);
var_dump(0b111111111111111111111111111111111111111111111111111111111);
var_dump(0b1111111111111111111111111111111111111111111111111111111111);
var_dump(0b11111111111111111111111111111111111111111111111111111111111);
var_dump(0b111111111111111111111111111111111111111111111111111111111111);
var_dump(0b1111111111111111111111111111111111111111111111111111111111111);
var_dump(0b11111111111111111111111111111111111111111111111111111111111111);
var_dump(0b111111111111111111111111111111111111111111111111111111111111111);
var_dump(0b1111111111111111111111111111111111111111111111111111111111111111);

var_dump(-0b1111111111111111111111111111111111111111111111111111111111111111);
var_dump(-0b111111111111111111111111111111111111111111111111111111111111111);
var_dump(-0b11111111111111111111111111111111111111111111111111111111111111);
var_dump(-0b111111111111111111111111111111111);
var_dump(-0b11111111111111111111111111111111);
var_dump(-0b1111111111111111111111111111111);
var_dump(-0b111111111111111111111111111111);
var_dump(-0b1);
?>
int(1)
int(3)
int(7)
int(15)
int(31)
int(63)
int(127)
int(255)
int(511)
int(1023)
int(2047)
int(4095)
int(8191)
int(16383)
int(32767)
int(65535)
int(131071)
int(262143)
int(524287)
int(1048575)
int(2097151)
int(4194303)
int(8388607)
int(16777215)
int(33554431)
int(67108863)
int(134217727)
int(268435455)
int(536870911)
int(1073741823)
int(2147483647)
float(4294967295)
float(8589934591)
float(17179869183)
float(34359738367)
float(68719476735)
float(137438953471)
float(274877906943)
float(549755813887)
float(1099511627775)
float(2199023255551)
float(4398046511103)
float(8796093022207)
float(17592186044415)
float(35184372088831)
float(70368744177663)
float(1.4073748835533E+14)
float(2.8147497671066E+14)
float(5.6294995342131E+14)
float(1.1258999068426E+15)
float(2.2517998136852E+15)
float(4.5035996273705E+15)
float(9.007199254741E+15)
float(1.8014398509482E+16)
float(3.6028797018964E+16)
float(7.2057594037928E+16)
float(1.4411518807586E+17)
float(2.8823037615171E+17)
float(5.7646075230342E+17)
float(1.1529215046068E+18)
float(2.3058430092137E+18)
float(4.6116860184274E+18)
float(9.2233720368548E+18)
float(1.844674407371E+19)
float(-1.844674407371E+19)
float(-9.2233720368548E+18)
float(-4.6116860184274E+18)
float(-8589934591)
float(-4294967295)
int(-2147483647)
int(-1073741823)
int(-1)