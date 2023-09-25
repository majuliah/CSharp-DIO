namespace NuggetSerializarEatributos.Models
{
    /// <summary>
    /// Este T é um genérico, essa classe pode substituir o T pelo tipo que queremos passar
    /// </summary>
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private int contador = 0;
        private T[] array = new T[capacidade];

        public void AdicionarElementoArray(T element)
        {
            if (contador + 1 < 11)
                array[contador] = element;
            
            contador++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}