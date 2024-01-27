using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

	private static string[] wordList = {   "int", "string", "if", "else", "for", "while", "do", "switch",
                                        "case", "break", "continue", "return", "include", "iostream",
                                        "ostream", "istream", "fstream", "iomanip", "using", "namespace",
                                        "cin", "cout", "cerr", "endl", "true", "false", "nullptr",
                                        "nullptr_t", "sizeof", "static", "class", "struct", "public",
                                        "private", "protected", "virtual", "override", "const", "volatile",
                                        "template", "typename", "auto", "new", "delete", "dynamic_cast",
                                        "static_cast", "reinterpret_cast", "try", "catch", "throw", "main",
                                        "bool", "char", "wchar_t", "float", "double", "short", "long",
                                        "signed", "unsigned", "void", "friend", "operator", "this", "nullptr",
                                        "nullptr_t", "sizeof", "alignof", "typeid", "decltype", "const_cast",
                                        "volatile_cast", "enum", "union", "namespace", "using", "mutable",
                                        "explicit", "extern", "register", "goto", "volatile", "extern", "register",
                                        "goto", "constexpr", "noexcept", "thread_local", "alignas", "alignof",
                                        "alignas", "alignof", "constexpr", "noexcept", "thread_local", "and",
                                        "and_eq", "bitand", "bitor", "compl", "not", "not_eq", "or", "or_eq",
                                        "xor", "xor_eq", "asm", "nullptr", "decltype", "final", "override",
                                        "constexpr", "noexcept", "thread_local", "alignas", "alignof", "alignof",
                                        "constexpr", "noexcept", "thread_local", "and", "and_eq", "bitand",
                                        "bitor", "compl", "not", "not_eq", "or", "or_eq", "xor", "xor_eq",
                                        "asm", "asm", "asm", "asm", "asm", "asm", "asm", "asm", "asm", "asm"
                                    };


	public static string GetRandomWord ()
	{
		int randomIndex = Random.Range(0, wordList.Length);
		string randomWord = wordList[randomIndex];

		return randomWord;
	}

}
