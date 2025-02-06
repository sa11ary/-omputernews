body {
    font-family: Arial, sans-serif;
background - color: #f0f0f0;
    color: #333;
    margin: 0;
padding: 0;
}

header {
    background-color: #4CAF50;
    color: white;
padding: 1em 0;
text - align: center;
position: fixed;
width: 100 %;
top: 0;
left: 0;
z - index: 1000;
transition: transform 0.4s ease-in-out;
}

.hide - header {
transform: translateY(-100 %);
}

nav ul
{
    list-style-type: none;
    padding: 0;
    margin: 0;
}

nav ul li {
    display: inline;
margin: 0 15px;
}

nav ul li a {
    color: white;
text - decoration: none;
font - weight: bold;
cursor: pointer;
}

nav ul li a:hover {
    text-decoration: underline;
}

main {
    padding: 100px 20px 20px;
}

section {
    margin-bottom: 20px;
padding: 20px;
background - color: white;
border - radius: 8px;
box - shadow: 0 0 10px rgba(0, 0, 0, 0.1);
}

.faq - item {
    margin - bottom: 10px;
border: 1px solid #ccc;
    border - radius: 5px;
overflow: hidden;
}

.faq - question {
padding: 10px;
    background - color: #4CAF50;
    color: white;
cursor: pointer;
display: flex;
    justify - content: space - between;
    align - items: center;
}

.faq - answer {
display: none;
padding: 10px;
    background - color: white;
color: #333;
}

.arrow {
    font-weight: bold;
transition: transform 0.3s ease-in-out;
}

.open.faq - answer {
display: block;
}

.open.faq - question.arrow {
transform: rotate(180deg);
}
