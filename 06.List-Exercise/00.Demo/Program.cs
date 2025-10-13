// ===== 1. СЪЗДАВАНЕ НА LIST =====
Console.WriteLine("1. СЪЗДАВАНЕ НА LIST");
Console.WriteLine("-------------------");

// Празен списък
List<int> numbers = new List<int>();
    
// Списък с начални елементи
List<string> names = new List<string> { "Иван", "Мария", "Петър", "Дидо" };
names.Add("Gosho");

// Списък с капацитет (оптимизация)
List<int> numbersWithCapacity = new List<int>(100);

Console.WriteLine($"Празен списък: Count = {numbers.Count}");
Console.WriteLine($"Празен списък: Capacity = {numbers.Capacity}");
Console.WriteLine($"Списък с елементи: Count = {names.Count}");
Console.WriteLine($"Списък с елементи: Capacity = {names.Capacity}");
Console.WriteLine($"Списък с начален капацитет: Count = {numbersWithCapacity.Count}");
Console.WriteLine($"Списък с начален капацитет: Capacity = {numbersWithCapacity.Capacity}");
Console.WriteLine();

// ===== 2. ДОБАВЯНЕ НА ЕЛЕМЕНТИ =====
Console.WriteLine("2. ДОБАВЯНЕ НА ЕЛЕМЕНТИ");
Console.WriteLine("-----------------------");

// Add - добавя елемент в края
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
Console.WriteLine($"Add(10, 20, 30): {string.Join(", ", numbers)}");

// AddRange - добавя колекция елементи
numbers.AddRange(new int[] { 40, 50, 60 });
Console.WriteLine($"AddRange([40,50,60]): {string.Join(", ", numbers)}");

// Insert - вмъква елемент на конкретна позиция
numbers.Insert(2, 25); // индекс 2
Console.WriteLine($"Insert(2, 25): {string.Join(", ", numbers)}");
Console.WriteLine();

// ===== 3. ДОСТЪП ДО ЕЛЕМЕНТИ =====
Console.WriteLine("3. ДОСТЪП ДО ЕЛЕМЕНТИ");
Console.WriteLine("---------------------");

Console.WriteLine($"numbers[0] = {numbers[0]}");
Console.WriteLine($"numbers[3] = {numbers[3]}");

// Модификация
numbers[0] = 15;
Console.WriteLine($"След numbers[0] = 15: {string.Join(", ", numbers)}");
Console.WriteLine();

// ===== 4. ТЪРСЕНЕ И ПРОВЕРКИ =====
Console.WriteLine("4. ТЪРСЕНЕ И ПРОВЕРКИ");
Console.WriteLine("---------------------");

// Contains - проверява дали елемент съществува
Console.WriteLine($"Contains(25): {numbers.Contains(25)}");
Console.WriteLine($"Contains(100): {numbers.Contains(100)}");

// IndexOf - връща индекса на елемент (-1 ако не съществува)
Console.WriteLine($"IndexOf(30): {numbers.IndexOf(30)}");
Console.WriteLine($"IndexOf(999): {numbers.IndexOf(999)}");

// Find - намира първия елемент, който отговаря на условие
int firstLarge = numbers.Find(x => x > 30);
Console.WriteLine($"Find(x > 30): {firstLarge}");

// FindAll - връща всички елементи, които отговарят на условие
List<int> largeNumbers = numbers.FindAll(x => x >= 30);
Console.WriteLine($"FindAll(x >= 30): {string.Join(", ", largeNumbers)}");

// Exists - проверява дали съществува елемент с условие
Console.WriteLine($"Exists(x > 50): {numbers.Exists(x => x > 50)}");
Console.WriteLine();

// ===== 5. ПРЕМАХВАНЕ НА ЕЛЕМЕНТИ =====
Console.WriteLine("5. ПРЕМАХВАНЕ НА ЕЛЕМЕНТИ");
Console.WriteLine("-------------------------");

List<int> temp = new List<int>(numbers); // копие за демо

// Remove - премахва първата поява на елемент
temp.Remove(25);
Console.WriteLine($"Remove(25): {string.Join(", ", temp)}");

// RemoveAt - премахва елемент на индекс
temp.RemoveAt(0);
Console.WriteLine($"RemoveAt(0): {string.Join(", ", temp)}");

// RemoveAll - премахва всички елементи с условие
temp.RemoveAll(x => x < 30);
Console.WriteLine($"RemoveAll(x < 30): {string.Join(", ", temp)}");

// Clear - изчиства всички елементи
temp.Clear();
Console.WriteLine($"Clear(): Count = {temp.Count}");
Console.WriteLine();

// ===== 6. СОРТИРАНЕ И ОБРЪЩАНЕ =====
Console.WriteLine("6. СОРТИРАНЕ И ОБРЪЩАНЕ");
Console.WriteLine("-----------------------");

List<int> unsorted = new List<int> { 50, 20, 60, 10, 40, 30 };
Console.WriteLine($"Оригинален: {string.Join(", ", unsorted)}");

// Sort - сортира във възходящ ред
unsorted.Sort();
Console.WriteLine($"Sort(): {string.Join(", ", unsorted)}");

// Reverse - обръща реда
unsorted.Reverse();
Console.WriteLine($"Reverse(): {string.Join(", ", unsorted)}");

// Sort с custom comparator (низходящ)
unsorted.Sort((a, b) => b.CompareTo(a));
Console.WriteLine($"Sort(низходящ): {string.Join(", ", unsorted)}");
Console.WriteLine();

// ===== 7. ИТЕРИРАНЕ =====
Console.WriteLine("7. ИТЕРИРАНЕ");
Console.WriteLine("------------");

List<string> fruits = new List<string> { "ябълка", "круша", "банан" };

// foreach
Console.Write("foreach: ");
foreach (string fruit in fruits)
{
    Console.Write($"{fruit} ");
}
Console.WriteLine();

// for с индекс
Console.Write("for: ");
for (int i = 0; i < fruits.Count; i++)
{
    Console.Write($"[{i}]={fruits[i]} ");
}
Console.WriteLine();

// ForEach метод
Console.Write("ForEach: ");
fruits.ForEach(f => Console.Write($"{f.ToUpper()} "));
Console.WriteLine("\n");

// ===== 8. ДРУГИ ПОЛЕЗНИ МЕТОДИ =====
Console.WriteLine("8. ДРУГИ ПОЛЕЗНИ МЕТОДИ");
Console.WriteLine("-----------------------");

List<int> nums = new List<int> { 1, 2, 3, 4, 5 };

// ToArray - конвертира в масив
int[] array = nums.ToArray();
Console.WriteLine($"ToArray(): [{string.Join(", ", array)}]");

// GetRange - взима подсписък
List<int> subList = nums.GetRange(1, 3); // от индекс 1, 3 елемента
Console.WriteLine($"GetRange(1, 3): {string.Join(", ", subList)}");

// TrueForAll - проверява дали всички елементи отговарят на условие
Console.WriteLine($"TrueForAll(x > 0): {nums.TrueForAll(x => x > 0)}");
Console.WriteLine();

// ===== 9. ПРОИЗВОДИТЕЛНОСТ =====
Console.WriteLine("9. КЛЮЧОВИ ФАКТИ");
Console.WriteLine("----------------");
Console.WriteLine("• List<T> е dynamic array (динамичен масив)");
Console.WriteLine("• Достъп по индекс: O(1)");
Console.WriteLine("• Add в края: O(1) средно");
Console.WriteLine("• Insert/RemoveAt: O(n)");
Console.WriteLine("• Contains/IndexOf: O(n)");
Console.WriteLine("• Автоматично преоразмеряване при нужда");
Console.WriteLine("• Generic: type-safe");

