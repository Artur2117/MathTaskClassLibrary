using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;

[TestClass]
public class GeometryTests
{
    // Корректные тесты (5 штук)
    [TestMethod]
    public void RectangleArea_3and5_15returned()
    {
        int a = 3;
        int b = 5;
        int expected = 15; // Ожидаемый результат: a * b
        Geometry g = new Geometry();
        int actual = g.S(a, b); // Фактический результат
        Assert.AreEqual(expected, actual); // Проверка
    }

    [TestMethod]
    public void RectangleArea_2and7_14returned()
    {
        int a = 2;
        int b = 7;
        int expected = 14; // Ожидаемый результат: a * b
        Geometry g = new Geometry();
        int actual = g.S(a, b); // Фактический результат
        Assert.AreEqual(expected, actual); // Проверка
    }

    [TestMethod]
    public void RectangleArea_1and3_3returned()
    {
        int a = 1;
        int b = 3;
        int expected = 3; // Ожидаемый результат: a * b
        Geometry g = new Geometry();
        int actual = g.S(a, b); // Фактический результат
        Assert.AreEqual(expected, actual); // Проверка
    }

    [TestMethod]
    public void RectangleArea_8and2_16returned()
    {
        int a = 8;
        int b = 2;
        int expected = 16; // Ожидаемый результат: a * b
        Geometry g = new Geometry();
        int actual = g.S(a, b); // Фактический результат
        Assert.AreEqual(expected, actual); // Проверка
    }

    [TestMethod]
    public void RectangleArea_6and4_24returned()
    {
        int a = 6;
        int b = 4;
        int expected = 24; // Ожидаемый результат: a * b
        Geometry g = new Geometry();
        int actual = g.S(a, b); // Фактический результат
        Assert.AreEqual(expected, actual); // Проверка
    }

    // Некорректные тесты (5 штук)
    [TestMethod]
    public void RectangleArea_4and6_30returned()
    {
        int a = 4;
        int b = 6;
        int expected = 24; // Ожидаемый результат: a * b
        Geometry g = new Geometry();
        int actual = g.S(a, b) + 6; // Фактический результат с ошибкой: a * b + 6
        Assert.AreEqual(expected, actual); // Ожидает 24, но получит 30
    }

    [TestMethod]
    public void RectangleArea_5and5_50returned()
    {
        int a = 5;
        int b = 5;
        int expected = 25; // Ожидаемый результат: a * b
        Geometry g = new Geometry();
        int actual = g.S(a, b) * 2; // Фактический результат с ошибкой: a * b * 2
        Assert.AreEqual(expected, actual); // Ожидает 25, но получит 50
    }

    [TestMethod]
    public void RectangleArea_6and4_36returned()
    {
        int a = 6;
        int b = 4;
        int expected = 24; // Ожидаемый результат: a * b
        Geometry g = new Geometry();
        int actual = g.S(a, b) + 12; // Фактический результат с ошибкой: a * b + 12
        Assert.AreEqual(expected, actual); // Ожидает 24, но получит 36
    }

    [TestMethod]
    public void RectangleArea_8and2_32returned()
    {
        int a = 8;
        int b = 2;
        int expected = 16; // Ожидаемый результат: a * b
        Geometry g = new Geometry();
        int actual = g.S(a, b) * 2; // Фактический результат с ошибкой: a * b * 2
        Assert.AreEqual(expected, actual); // Ожидает 16, но получит 32
    }

    [TestMethod]
    public void RectangleArea_7and3_42returned()
    {
        int a = 7;
        int b = 3;
        int expected = 21; // Ожидаемый результат: a * b
        Geometry g = new Geometry();
        int actual = g.S(a, b) * 2; // Фактический результат с ошибкой: a * b * 2
        Assert.AreEqual(expected, actual); // Ожидает 21, но получит 42
    }
}
[TestClass]
public class PerimeterTests
{
        // Корректные тесты (5 штук)
        [TestMethod]
    public void RectanglePerimeter_3and5_16returned()
    {
        int a = 3;
        int b = 5;
        int expected = 2 * (a + b); // Ожидаемый результат: 2 * (3 + 5) = 16
        Geometry g = new Geometry();
        int actual = g.P(a, b); // Фактический результат
        Assert.AreEqual(expected, actual); // Проверка
    }

    [TestMethod]
    public void RectanglePerimeter_2and7_18returned()
    {
        int a = 2;
        int b = 7;
        int expected = 2 * (a + b); // Ожидаемый результат: 2 * (2 + 7) = 18
        Geometry g = new Geometry();
        int actual = g.P(a, b); // Фактический результат
        Assert.AreEqual(expected, actual); // Проверка
    }

    [TestMethod]
    public void RectanglePerimeter_1and3_8returned()
    {
        int a = 1;
        int b = 3;
        int expected = 2 * (a + b); // Ожидаемый результат: 2 * (1 + 3) = 8
        Geometry g = new Geometry();
        int actual = g.P(a, b); // Фактический результат
        Assert.AreEqual(expected, actual); // Проверка
    }

    [TestMethod]
    public void RectanglePerimeter_4and6_20returned()
    {
        int a = 4;
        int b = 6;
        int expected = 2 * (a + b); // Ожидаемый результат: 2 * (4 + 6) = 20
        Geometry g = new Geometry();
        int actual = g.P(a, b); // Фактический результат
        Assert.AreEqual(expected, actual); // Проверка
    }

    [TestMethod]
    public void RectanglePerimeter_8and2_20returned()
    {
        int a = 8;
        int b = 2;
        int expected = 2 * (a + b); // Ожидаемый результат: 2 * (8 + 2) = 20
        Geometry g = new Geometry();
        int actual = g.P(a, b); // Фактический результат
        Assert.AreEqual(expected, actual); // Проверка
    }

    // Некорректные тесты (5 штук)
    [TestMethod]
    public void RectanglePerimeter_3and5_22returned()
    {
        int a = 3;
        int b = 5;
        int expected = 2 * (a + b); // Ожидаемый результат: 2 * (3 + 5) = 16
        Geometry g = new Geometry();
        int actual = g.P(a, b) + 6; // Фактический результат с ошибкой: 16 + 6 = 22
        Assert.AreEqual(expected, actual); // Ожидает 16, но получит 22
    }

    [TestMethod]
    public void RectanglePerimeter_2and7_25returned()
    {
        int a = 2;
        int b = 7;
        int expected = 2 * (a + b); // Ожидаемый результат: 2 * (2 + 7) = 18
        Geometry g = new Geometry();
        int actual = g.P(a, b) + 7; // Фактический результат с ошибкой: 18 + 7 = 25
        Assert.AreEqual(expected, actual); // Ожидает 18, но получит 25
    }

    [TestMethod]
    public void RectanglePerimeter_1and3_12returned()
    {
        int a = 1;
        int b = 3;
        int expected = 2 * (a + b); // Ожидаемый результат: 2 * (1 + 3) = 8
        Geometry g = new Geometry();
        int actual = g.P(a, b) + 4; // Фактический результат с ошибкой: 8 + 4 = 12
        Assert.AreEqual(expected, actual); // Ожидает 8, но получит 12
    }

    [TestMethod]
    public void RectanglePerimeter_4and6_30returned()
    {
        int a = 4;
        int b = 6;
        int expected = 2 * (a + b); // Ожидаемый результат: 2 * (4 + 6) = 20
        Geometry g = new Geometry();
        int actual = g.P(a, b) + 10; // Фактический результат с ошибкой: 20 + 10 = 30
        Assert.AreEqual(expected, actual); // Ожидает 20, но получит 30
    }

    [TestMethod]
    public void RectanglePerimeter_8and2_30returned()
    {
        int a = 8;
        int b = 2;
        int expected = 2 * (a + b); // Ожидаемый результат: 2 * (8 + 2) = 20
        Geometry g = new Geometry();
        int actual = g.P(a, b) + 10; // Фактический результат с ошибкой: 20 + 10 = 30
        Assert.AreEqual(expected, actual); // Ожидает 20, но получит 30
    }
} 
[TestClass]
public class CylinderVolumeTests
{
    // Корректные тесты (5 штук)
    [TestMethod]
    public void CylinderVolume_2and5_62_80returned()
    {
        double r = 2.0;
        double h = 5.0;
        double expected = 3.14 * r * r * h; // Ожидаемый результат: 3.14 * 2² * 5 = 62.8
        Geometry g = new Geometry();
        double actual = g.V(r, h); // Фактический результат
        Assert.AreEqual(expected, actual, 0.01); // Проверка с погрешностью 0.01
    }

    [TestMethod]
    public void CylinderVolume_1and3_9_42returned()
    {
        double r = 1.0;
        double h = 3.0;
        double expected = 3.14 * r * r * h; // Ожидаемый результат: 3.14 * 1² * 3 = 9.42
        Geometry g = new Geometry();
        double actual = g.V(r, h); // Фактический результат
        Assert.AreEqual(expected, actual, 0.01); // Проверка с погрешностью 0.01
    }

    [TestMethod]
    public void CylinderVolume_3and4_113_04returned()
    {
        double r = 3.0;
        double h = 4.0;
        double expected = 3.14 * r * r * h; // Ожидаемый результат: 3.14 * 3² * 4 = 113.04
        Geometry g = new Geometry();
        double actual = g.V(r, h); // Фактический результат
        Assert.AreEqual(expected, actual, 0.01); // Проверка с погрешностью 0.01
    }

    [TestMethod]
    public void CylinderVolume_2and7_87_92returned()
    {
        double r = 2.0;
        double h = 7.0;
        double expected = 3.14 * r * r * h; // Ожидаемый результат: 3.14 * 2² * 7 = 87.92
        Geometry g = new Geometry();
        double actual = g.V(r, h); // Фактический результат
        Assert.AreEqual(expected, actual, 0.01); // Проверка с погрешностью 0.01
    }

    [TestMethod]
    public void CylinderVolume_4and3_150_72returned()
    {
        double r = 4.0;
        double h = 3.0;
        double expected = 3.14 * r * r * h; // Ожидаемый результат: 3.14 * 4² * 3 = 150.72
        Geometry g = new Geometry();
        double actual = g.V(r, h); // Фактический результат
        Assert.AreEqual(expected, actual, 0.01); // Проверка с погрешностью 0.01
    }

    // Некорректные тесты (5 штук)
    [TestMethod]
    public void CylinderVolume_2and5_75_80returned()
    {
        double r = 2.0;
        double h = 5.0;
        double expected = 3.14 * r * r * h; // Ожидаемый результат: 3.14 * 2² * 5 = 62.8
        Geometry g = new Geometry();
        double actual = g.V(r, h) + 13.0; // Фактический результат с ошибкой: 62.8 + 13 = 75.8
        Assert.AreEqual(expected, actual, 0.01); // Ожидает 62.8, но получит 75.8
    }

    [TestMethod]
    public void CylinderVolume_1and3_15_42returned()
    {
        double r = 1.0;
        double h = 3.0;
        double expected = 3.14 * r * r * h; // Ожидаемый результат: 3.14 * 1² * 3 = 9.42
        Geometry g = new Geometry();
        double actual = g.V(r, h) + 6.0; // Фактический результат с ошибкой: 9.42 + 6 = 15.42
        Assert.AreEqual(expected, actual, 0.01); // Ожидает 9.42, но получит 15.42
    }

    [TestMethod]
    public void CylinderVolume_3and4_150_04returned()
    {
        double r = 3.0;
        double h = 4.0;
        double expected = 3.14 * r * r * h; // Ожидаемый результат: 3.14 * 3² * 4 = 113.04
        Geometry g = new Geometry();
        double actual = g.V(r, h) + 37.0; // Фактический результат с ошибкой: 113.04 + 37 = 150.04
        Assert.AreEqual(expected, actual, 0.01); // Ожидает 113.04, но получит 150.04
    }

    [TestMethod]
    public void CylinderVolume_2and7_120_92returned()
    {
        double r = 2.0;
        double h = 7.0;
        double expected = 3.14 * r * r * h; // Ожидаемый результат: 3.14 * 2² * 7 = 87.92
        Geometry g = new Geometry();
        double actual = g.V(r, h) + 33.0; // Фактический результат с ошибкой: 87.92 + 33 = 120.92
        Assert.AreEqual(expected, actual, 0.01); // Ожидает 87.92, но получит 120.92
    }

    [TestMethod]
    public void CylinderVolume_4and3_180_72returned()
    {
        double r = 4.0;
        double h = 3.0;
        double expected = 3.14 * r * r * h; // Ожидаемый результат: 3.14 * 4² * 3 = 150.72
        Geometry g = new Geometry();
        double actual = g.V(r, h) + 30.0; // Фактический результат с ошибкой: 150.72 + 30 = 180.72
        Assert.AreEqual(expected, actual, 0.01); // Ожидает 150.72, но получит 180.72
    }
}
[TestClass]
public class ParallelepipedTests
{
    // Тесты для объёма (3 верных, 2 неверных)
    [TestMethod]
    public void ParallelepipedVolume_2and3and4_24returned()
    {
        int a = 2;
        int b = 3;
        int c = 4;
        int expected = a * b * c; // Ожидаемый результат: 2 * 3 * 4 = 24
        Geometry g = new Geometry();
        int actual = g.ParallelepipedVolume(a, b, c);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ParallelepipedVolume_1and5and2_10returned()
    {
        int a = 1;
        int b = 5;
        int c = 2;
        int expected = a * b * c; // Ожидаемый результат: 1 * 5 * 2 = 10
        Geometry g = new Geometry();
        int actual = g.ParallelepipedVolume(a, b, c);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ParallelepipedVolume_3and3and3_27returned()
    {
        int a = 3;
        int b = 3;
        int c = 3;
        int expected = a * b * c; // Ожидаемый результат: 3 * 3 * 3 = 27
        Geometry g = new Geometry();
        int actual = g.ParallelepipedVolume(a, b, c);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ParallelepipedVolume_2and3and4_34returned()
    {
        int a = 2;
        int b = 3;
        int c = 4;
        int expected = a * b * c; // Ожидаемый результат: 2 * 3 * 4 = 24
        Geometry g = new Geometry();
        int actual = g.ParallelepipedVolume(a, b, c) + 10; // Ошибка: 24 + 10 = 34
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ParallelepipedVolume_1and5and2_20returned()
    {
        int a = 1;
        int b = 5;
        int c = 2;
        int expected = a * b * c; // Ожидаемый результат: 1 * 5 * 2 = 10
        Geometry g = new Geometry();
        int actual = g.ParallelepipedVolume(a, b, c) * 2; // Ошибка: 10 * 2 = 20
        Assert.AreEqual(expected, actual);
    }

    // Тесты для площади поверхности (2 верных, 3 неверных)
    [TestMethod]
    public void ParallelepipedSurfaceArea_2and3and4_52returned()
    {
        int a = 2;
        int b = 3;
        int c = 4;
        int expected = 2 * (a * b + b * c + a * c); // Ожидаемый результат: 2 * (2*3 + 3*4 + 2*4) = 2 * (6 + 12 + 8) = 52
        Geometry g = new Geometry();
        int actual = g.ParallelepipedSurfaceArea(a, b, c);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ParallelepipedSurfaceArea_1and5and2_34returned()
    {
        int a = 1;
        int b = 5;
        int c = 2;
        int expected = 2 * (a * b + b * c + a * c); // Ожидаемый результат: 2 * (1*5 + 5*2 + 1*2) = 2 * (5 + 10 + 2) = 34
        Geometry g = new Geometry();
        int actual = g.ParallelepipedSurfaceArea(a, b, c);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ParallelepipedSurfaceArea_3and3and3_60returned()
    {
        int a = 3;
        int b = 3;
        int c = 3;
        int expected = 2 * (a * b + b * c + a * c); // Ожидаемый результат: 2 * (3*3 + 3*3 + 3*3) = 2 * (9 + 9 + 9) = 54
        Geometry g = new Geometry();
        int actual = g.ParallelepipedSurfaceArea(a, b, c) + 6; // Ошибка: 54 + 6 = 60
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ParallelepipedSurfaceArea_2and3and4_62returned()
    {
        int a = 2;
        int b = 3;
        int c = 4;
        int expected = 2 * (a * b + b * c + a * c); // Ожидаемый результат: 2 * (2*3 + 3*4 + 2*4) = 52
        Geometry g = new Geometry();
        int actual = g.ParallelepipedSurfaceArea(a, b, c) + 10; // Ошибка: 52 + 10 = 62
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ParallelepipedSurfaceArea_1and5and2_44returned()
    {
        int a = 1;
        int b = 5;
        int c = 2;
        int expected = 2 * (a * b + b * c + a * c); // Ожидаемый результат: 2 * (1*5 + 5*2 + 1*2) = 34
        Geometry g = new Geometry();
        int actual = g.ParallelepipedSurfaceArea(a, b, c) + 10; // Ошибка: 34 + 10 = 44
        Assert.AreEqual(expected, actual);
    }
}