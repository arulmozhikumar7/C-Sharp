# List of Common LINQ Methods in C# 

| **Category**         | **Method**           | **Description**                                    | **Example** |
|----------------------|---------------------|--------------------------------------------------|-------------|
| **Filtering**       | `Where`              | Filters elements based on a condition.          | `students.Where(s => s.Grade > 80)` |
|                     | `Distinct`           | Removes duplicate elements from a collection.   | `students.Select(s => s.Grade).Distinct()` |
| **Sorting**         | `OrderBy`            | Sorts elements in ascending order.             | `students.OrderBy(s => s.Grade)` |
|                     | `OrderByDescending`  | Sorts elements in descending order.            | `students.OrderByDescending(s => s.Grade)` |
|                     | `ThenBy`             | Secondary sorting in ascending order.          | `students.OrderBy(s => s.Grade).ThenBy(s => s.Name)` |
|                     | `ThenByDescending`   | Secondary sorting in descending order.         | `students.OrderByDescending(s => s.Grade).ThenByDescending(s => s.Age)` |
| **Projection**      | `Select`             | Projects each element into a new form.         | `students.Select(s => s.Name)` |
|                     | `SelectMany`         | Flattens nested collections.                   | `departments.SelectMany(d => d.Students)` |
| **Aggregation**     | `Count`              | Returns the number of elements.                | `students.Count()` |
|                     | `Sum`                | Returns the sum of elements.                   | `students.Sum(s => s.Grade)` |
|                     | `Average`            | Returns the average value.                     | `students.Average(s => s.Grade)` |
|                     | `Min`                | Returns the minimum value.                     | `students.Min(s => s.Grade)` |
|                     | `Max`                | Returns the maximum value.                     | `students.Max(s => s.Grade)` |
| **Set Operations**  | `Union`              | Returns unique elements from two collections.  | `list1.Union(list2)` |
|                     | `Intersect`          | Returns common elements from two collections.  | `list1.Intersect(list2)` |
|                     | `Except`             | Returns elements in the first collection not in the second. | `list1.Except(list2)` |
| **Element Access**  | `First`              | Returns the first element; throws error if empty. | `students.First(s => s.Grade > 90)` |
|                     | `FirstOrDefault`     | Returns the first element or default if not found. | `students.FirstOrDefault(s => s.Grade > 100)` |
|                     | `Last`               | Returns the last element; throws error if empty. | `students.Last(s => s.Grade > 90)` |
|                     | `LastOrDefault`      | Returns the last element or default if not found. | `students.LastOrDefault(s => s.Grade > 100)` |
|                     | `Single`             | Returns one element; throws error if more than one. | `students.Single(s => s.Name == "Student1")` |
|                     | `SingleOrDefault`    | Returns one element or default if none found. | `students.SingleOrDefault(s => s.Name == "Student1")` |
| **Checking Conditions** | `Any`           | Checks if any element matches a condition.     | `students.Any(s => s.Grade > 90)` |
|                     | `All`                | Checks if all elements match a condition.      | `students.All(s => s.Grade > 50)` |
|                     | `Contains`           | Checks if the collection contains a specific value. | `students.Select(s => s.Name).Contains("Student1")` |
| **Grouping**        | `GroupBy`            | Groups elements based on a key.                | `students.GroupBy(s => s.Grade)` |
| **Conversion**      | `ToList`             | Converts to a List.                            | `students.Where(s => s.Grade > 80).ToList()` |
|                     | `ToArray`            | Converts to an Array.                          | `students.Select(s => s.Name).ToArray()` |
|                     | `ToDictionary`       | Converts to a Dictionary.                      | `students.ToDictionary(s => s.Name, s => s.Grade)` |


