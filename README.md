# Python Documentation

# Word Counter Python Script

This Python script is a simple word counter. It takes a sentence as input from the user and counts the frequency of each word in the sentence. The script then prints out each word along with its frequency.

## Libraries Used

### Collections

The `collections` library is a built-in Python module for handling different types of containers. In this script, we use the `Counter` class from the `collections` library. `Counter` is a dict subclass for counting hashable objects. It is a collection where elements are stored as dictionary keys and their counts are stored as dictionary values.

### Re

The `re` library is a built-in Python module for working with regular expressions. Regular expressions are a powerful tool for various kinds of string manipulation. In this script, we use the `findall` function from the `re` library to extract all the words from the input sentence. The `findall` function returns all non-overlapping matches of pattern in string, as a list of strings.

## How the Script Works

The script defines a function `word_counter` that does the following:

1. It prompts the user to enter a sentence.
2. It uses the `findall` function from the `re` library to extract all the words from the sentence. The regular expression `\b\w+\b` is used to match all words in the sentence.
3. It uses the `Counter` class from the `collections` library to count the frequency of each word in the list of words.
4. It iterates over the `Counter` object and prints out each word along with its frequency.

The script then calls the `word_counter` function if the script is run as a standalone program.

---

# C# Documentation

# Word Count Program in C#

This is a simple C# console application that counts the occurrence of each word in a sentence input by the user.

## How it works

The program prompts the user to enter a sentence. It then splits the sentence into individual words and counts the occurrence of each word. The results are then displayed to the user.

## Code Explanation

The script uses the following namespaces:

- `System`: This namespace contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions.

- `System.Collections.Generic`: This namespace contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.

- `System.Linq`: This namespace provides classes and interfaces that support queries that use Language-Integrated Query (LINQ).

The `Main` method is the entry point of the program. It first prompts the user to enter a sentence and reads the input. It then splits the sentence into words and counts the occurrence of each word using a dictionary. Finally, it prints out the word count to the console.

## Usage

To run the program, you need a C# compiler. If you are using Visual Studio, you can simply open the project and press F5 to run the program. If you are using a different IDE or text editor, you may need to compile and run the program manually.

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License

[MIT](https://choosealicense.com/licenses/mit/)

---

# Java Documentation

# Java Word Counter

This Java script is a simple word counter. It takes a sentence as input from the user and counts the frequency of each word in the sentence. The script then outputs each word along with its frequency.

## Script Explanation

The script begins by importing three Java libraries:

- `java.util.HashMap`: This library provides the `HashMap` class which is used to store the words and their frequencies. A `HashMap` stores key-value pairs, in this case the word is the key and the frequency is the value.

- `java.util.Map`: This library provides the `Map` interface which is used to manipulate entries in the `HashMap`.

- `java.util.Scanner`: This library provides the `Scanner` class which is used to read the user's input.

The `main` method begins by creating a `Scanner` object to read the user's input. It then prompts the user to enter a sentence.

The sentence is then split into an array of words using the `split` method. A `HashMap` is created to store the words and their frequencies.

The script then iterates over the array of words. For each word, if it is already in the `HashMap`, its frequency is incremented by 1. If it is not in the `HashMap`, it is added with a frequency of 1.

Finally, the script iterates over the entries in the `HashMap` and prints each word along with its frequency.

## Usage

To use this script, simply run it in a Java environment. When prompted, enter a sentence. The script will then output the frequency of each word in the sentence.

---
