
<!DOCTYPE html>
<html>
<head lang="en-us">
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width">
  <link href='https://fonts.googleapis.com/css?family=Oswald:700|Open+Sans+Condensed:300|Poiret+One' rel='stylesheet' type='text/css'>
  <link rel="stylesheet" href="http://codingdojo.org/css/codingdojo.css">
  <title>KataMinesweeper - Coding Dojo</title>
  <meta name="generator" content="Hugo 0.18.1" />

  
  <link rel="canonical" href="http://codingdojo.org/kata/Minesweeper/">
  

  <meta property="og:url" content="http://codingdojo.org/kata/Minesweeper/">
  <meta property="og:title" content="Coding Dojo">
  
  <meta name="apple-mobile-web-app-title" content="Coding Dojo">
  <meta name="apple-mobile-web-app-capable" content="yes">
  <meta name="apple-mobile-web-app-status-bar-style" content="black-translucent">

  <link rel="shortcut icon" type="image/x-icon" href="http://codingdojo.org/images/favicon.ico">
  <link rel="icon" type="image/x-icon" href="http://codingdojo.org/images/favicon.ico">
</head>

<body>
  <header class="top">
    <h1><a href=/>Coding Dojo</a></h1>
    <nav>
      <ul>
         Taken from http://codingdojo.org/kata/Minesweeper/ 
  	 Go there for this same description. 
        
      </ul>
    </nav>
</header>

  <article class="page">
    <div class="content">
      <p><strong>About this Kata</strong></p>

<p>Kata originated here: acm.uva.es/p/v101/10189.html</p>

<p>Difficulty: Easy</p>

<p><strong>Problem Description</strong></p>

<p>Have you ever played Minesweeper? It&rsquo;s a cute little game which comes
within a certain Operating System whose name we can&rsquo;t really remember.
Well, the goal of the game is to find all the mines within an MxN field.
To help you, the game shows a number in a square which tells you how
many mines there are adjacent to that square. For instance, take the
following 4x4 field with 2 mines (which are represented by an *
character):</p>

<pre><code>*...
....
.*..
....
</code></pre>

<p>The same field including the hint numbers described above would look
like this:</p>

<pre><code>*100
2210
1*10
1110
</code></pre>

<p>You should write a program that takes input as follows:</p>

<p>The input will consist of an arbitrary number of fields. The first line
of each field contains two integers n and m (0 &lt; n,m &lt;= 100) which
stands for the number of lines and columns of the field respectively.
The next n lines contains exactly m characters and represent the field.
Each safe square is represented by an &ldquo;.&rdquo; character (without the quotes)
and each mine square is represented by an &ldquo;*&rdquo; character (also without
the quotes). The first field line where n = m = 0 represents the end of
input and should not be processed.</p>

<p>Your program should produce output as follows:</p>

<p>For each field, you must print the following message in a line alone:</p>

<p>Field #x:</p>

<p>Where x stands for the number of the field (starting from 1). The next n
lines should contain the field with the &ldquo;.&rdquo; characters replaced by the
number of adjacent mines to that square. There must be an empty line
between field outputs.</p>

<p><strong>Clues</strong></p>

<p>As you may have already noticed, each square may have at most 8 adjacent
squares.</p>

<p><strong>Suggested Test Cases</strong></p>

<p>This is the acceptance test input:</p>

<pre><code>4 4
*...
....
.*..
....
3 5
**...
.....
.*...
0 0
</code></pre>

<p>and output:</p>

<pre><code>Field #1:
*100
2210
1*10
1110

Field #2:
**100
33200
1*100
</code></pre>

<hr />

<p><strong>Comments from those who are working on this Kata</strong></p>

<p>This Kata was tackled at the <a href="http://codingdojo.org/dojo/SaoPauloDojo">SaoPauloDojo</a> and
results described <a href="http://codingdojo.org/record/2007Aug29SPDojo">here</a> .</p>

<p>The Kata was done by <a href="http://codingdojo.org/dojo/YouDevise">YouDevise</a> and results described
at tinyurl.com/6falq7</p>

<p>The Kata was done by Songkick.com and the test framework and solution
posted at
github.com/mattwynne/software-craftsmanship-katas/tree/master/minesweeper</p>

<p>Macluq has posted his solution on Github :
<a href="https://github.com/macluq/KataMinesweeper">https://github.com/macluq/KataMinesweeper</a></p>

</body>

