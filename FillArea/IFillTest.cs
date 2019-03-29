namespace FillTest
{
    public interface IFillTest
    {
        /// <summary>
        /// Возвращает область с помощью волнового алгоритма
        /// </summary>
        /// <param name="points">Массив байтов (в нем лежат пиксели с прозрачностью 0-255)</param>
        /// <param name="trashold">Порог при котором прозрачность является стенкой</param>
        /// <param name="startX">Начальная позиция волны по X</param>
        /// <param name="startY">Начальная позиция волны по Y</param>
        /// <param name="width">Ширина поля</param>
        /// <param name="heigth">Высотая поля</param>
        /// <returns>Возвращаем список индексов заполненного поля</returns>
        int[] GetArea(byte[] points, byte trashold, int startX, int startY, int width, int heigth);
    }
}
