﻿/*Создайте класс и примените к его методам атрибут Obsolete сначала в форме, просто
выводящей предупреждение, а затем в форме, препятствующей компиляции.
Продемонстрируйте работу атрибута на примере вызова данных методов.*/

using SecondTask;

MyClass myClass = new MyClass();

myClass.MyMethodWarning();

myClass.MyMethodError();