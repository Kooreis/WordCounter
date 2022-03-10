import collections
import re

def word_counter():
    text = input("Enter a sentence: ")
    words = re.findall('\b\w+\b', text)
    word_count = collections.Counter(words)
    for word, count in word_count.items():
        print(f'{word}: {count}')

if __name__ == "__main__":
    word_counter()