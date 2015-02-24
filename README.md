# Infi Developers Meetup - F# Coding Dojo #

This repository contains a selection of Coding Dojo assignments to help people get started with F#. These assignments can also be found at [c4fsharp.net](http://c4fsharp.net).

All credits go to the original creators of each of the assignments. GitHub original repositories are listed below:

* 0. FSharpKoans: [https://github.com/ChrisMarinos/FSharpKoans](https://github.com/ChrisMarinos/FSharpKoans) 
* 1. DigitsRecognizer: [https://github.com/c4fsharp/Dojo-Digits-Recognizer](https://github.com/c4fsharp/Dojo-Digits-Recognizer)
* 2. Fractal Forest: [https://github.com/c4fsharp/Dojo-Fractal-Forest](https://github.com/c4fsharp/Dojo-Fractal-Forest)
* 3. Type Provider Treasure Hunt: [https://github.com/c4fsharp/Dojo-Type-Provider-Treasure-Hunt](https://github.com/c4fsharp/Dojo-Type-Provider-Treasure-Hunt)

## FSharpKoans ##

This assignment covers the absolute basics of F#. Highly recommended if you're not yet familiar with the language, or need to brush up.

*(description copied from [https://github.com/ChrisMarinos/FSharpKoans](https://github.com/ChrisMarinos/FSharpKoans))*

Inspired by EdgeCase's fantastic Ruby koans, the goal of the F# koans is to teach you F# through testing.

When you first run the koans, you'll be presented with a runtime error and a stack trace indicating where the error occured. Your goal is to make the error go away. As you fix each error, you should learn something about the F# language and functional programming in general.

Your journey towards F# enlightenment starts in the AboutAsserts.fs file. These koans will be very simple, so don't overthink them! As you progress through more koans, more and more F# syntax will be introduced which will allow you to solve more complicated problems and use more advanced techniques.

## DigitsRecognizer ##

Recommended if you're familiar with the basics of F# and want to start testing your skills.

*(description copied from [https://github.com/c4fsharp/Dojo-Digits-Recognizer](https://github.com/c4fsharp/Dojo-Digits-Recognizer))*

This Dojo is inspired by the [Kaggle Digit Recognizer contest](http://www.kaggle.com/c/digit-recognizer).
The goal is to write a Machine Learning classifier from scratch, a program that will recognize hand-written digits automatically.
It is a guided Dojo, suitable for beginners: the Dojo comes with a Script file, with specific tasks to complete, introducing along the way numerous F# concepts and syntax examples.


## Fractal Forest ##

Visual assignment to show the basics of recursion in F#.

*(description copied from [https://github.com/c4fsharp/Dojo-Fractal-Forest](https://github.com/c4fsharp/Dojo-Fractal-Forest))*

The dojo was inspired by the post ["Create Fractals with Recursive Drawing"](http://matthewjamestaylor.com/blog/create-fractals-with-recursive-drawing).
It is a good exercise in recursion.

## Type Provider Treasure Hunt ##

You will access data from different sources using the F# [F# Data library](http://fsharp.github.io/FSharp.Data/). In the first exercise of the assignment you will access an API and in the second you will read data from an XML-file.

The original Dojo contains five extra exercises, but the first two exercises will give you a good impression of the concept.

*(description copied from [https://github.com/c4fsharp/Dojo-Type-Provider-Treasure-Hunt](https://github.com/c4fsharp/Dojo-Type-Provider-Treasure-Hunt))*

This Dojo introduces F# type providers using those from the [F# Data library](http://fsharp.github.io/FSharp.Data/).

The goal of the Dojo is to find 7 secret words to find a secret phrase! To find each word, you need to solve a simple data access task using type providers - such as read XML document, perform JSON-based REST request or read data from the WorldBank; then perform simple processing to find the right word in the result and find the secret phrase! The Dojo comes with a script file containing 7 tasks - to make this a bit harder, the words are not in the original order, so you need to get most of them to find the secret phrase.
