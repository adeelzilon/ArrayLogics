public class ArrayManipulator
{
    public static void Main(string[] args)
    {
        InsertAtSpecificIndexWithSimpleLogic();
        InsertAtSpecificIndexWithCopyMethod();
        InsertAtSpecificIndexWithResizeMethod();
    }

    public static void InsertAtSpecificIndexWithSimpleLogic()
    {
        // Define the size of the array
        int size = 8;

        // Create and initialize the array
        int[] array = new int[size];

        // Display the array before insertion
        Console.WriteLine("Before Insertion");
        for (int i = 0; i < size - 1; i++)
        {
            array[i] = i;
            Console.WriteLine($"Element at Index {i}: {array[i]}");
        }

        // Define the index and element to be inserted
        int insertingIndex = 2;

        // Shift elements to make space for the new element
        for (int i = size - 2; i >= insertingIndex; i--)
        {
            array[i + 1] = array[i];
        }

        // Insert the element at the specified index
        array[insertingIndex] = 99;

        // Display the array after insertion
        Console.WriteLine("After Insertion");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Element at Index {i}: {array[i]}");
        }
    }

    public static void InsertAtSpecificIndexWithCopyMethod()
    {
        // Define the size of the original array
        int arraySize = 8;

        // Create the original array with the specified size
        int[] originalArray = new int[arraySize];

        // Create a temporary array with one additional element
        int[] tempArray = new int[originalArray.Length + 1];

        // Display the original array before insertion
        Console.WriteLine("Before Insertion");
        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = i;
            Console.WriteLine($"Element at Index {i}: {originalArray[i]}");
        }

        // Define the index and element to be inserted
        int insertingIndex = 2;
        int insertingElement = 99;

        // Copy the elements before the insertion index to the temporary array
        Array.Copy(originalArray, 0, tempArray, 0, insertingIndex);

        // Insert the element at the specified index
        tempArray[insertingIndex] = insertingElement;

        // Calculate the length of elements after the insertion index
        int insertionLength = originalArray.Length - insertingIndex;

        // Copy the remaining elements from the original array to the temporary array
        Array.Copy(originalArray, insertingIndex, tempArray, insertingIndex + 1, insertionLength);

        // Display a success message for the insertion
        Console.WriteLine($"Element {insertingElement} inserted successfully at index {insertingIndex}");

        // Update the original array to the modified temporary array
        originalArray = tempArray;

        // Display the original array after insertion
        Console.WriteLine("After Insertion");
        for (int i = 0; i < originalArray.Length; i++)
        {
            Console.WriteLine($"Element at Index {i}: {originalArray[i]}");
        }
    }

    public static void InsertAtSpecificIndexWithResizeMethod()
    {
        // Define the initial size of the array
        int size = 5;

        // Create an array with the specified size
        int[] array = new int[size];

        // Display the array before insertion
        Console.WriteLine("Before Insertion");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
            Console.WriteLine($"Element at Index {i}: {array[i]}");
        }

        // Resize the array to accommodate the new element
        Array.Resize(ref array, size + 1);

        // Define the index and element to be inserted
        int insertingIndex = 2;

        // Shift elements to make space for the new element
        for (int i = array.Length - 2; i >= insertingIndex; i--)
        {
            array[i + 1] = array[i];
        }

        // Insert the element at the specified index
        array[insertingIndex] = 99;

        // Display the array after insertion
        Console.WriteLine("After Insertion");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Element at Index {i}: {array[i]}");
        }
    }
}
