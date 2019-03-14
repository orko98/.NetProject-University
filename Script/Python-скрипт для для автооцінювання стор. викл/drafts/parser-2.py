import html2text

html = """<main class='content-area' role='main'>
<article class='content employee'>
<h1 class='page-title'>Байцар Андрій Любомирович</h1>
<section class='general has-image'>
<span class='photo' style='background-image: url(http://geography.lnu.edu.ua/wp-content/uploads/2015/03/Baitzar-125x150.jpg);'></span>
<div class='info'>
<p><span class='label'>Посада<span>:</span></span> <span class='value'>доцент <a href='http://geography.lnu.edu.ua/department/geographyofukraine'>кафедри географії України</a></span></p>
<p><span class='label'>Науковий ступінь<span>:</span></span> <span class='value'>кандидат географічних наук</span></p>
<p><span class='label'>Вчене звання<span>:</span></span> <span class='value'>доцент</span></p>
</div>
</section>
<section class='section'>
<h2>Наукові інтереси</h2>
<div><ul>
<li>Фізична географія України</li>
<li>Географія та історія Криму</li>
<li>Географічна термінологія</li>
<li>Географія та історія м. Винники</li>
<li>Картографія України</li>
</ul>
<p><span style="color: #000000;"><br />
</span></p>
</div>
</section>
<section class='section'>
<h2>Курси</h2>
<div><ul>
<li><a href='http://geography.lnu.edu.ua/course/heohrafichna-terminolohiya-2'>Географічна термінологія</a></li>
<li><a href='http://geography.lnu.edu.ua/course/heohrafichne-krajeznavstvo'>Географічне краєзнавство</a></li>
<li><a href='http://geography.lnu.edu.ua/course/heohrafiya-kultury-i-relihiji-v-ukrajini'>Географія культури і релігії в Україні</a></li>
<li><a href='http://geography.lnu.edu.ua/course/heohrafiya-ukrajinskyh-karpat-i-krymu'>Географія Українських Карпат і Криму</a></li>
<li><a href='http://geography.lnu.edu.ua/course/studentskyj-naukovyj-seminar-2'>Студентський науковий семінар</a></li>
<li><a href='http://geography.lnu.edu.ua/course/fizychna-heohrafiya-ukrajiny'>Фізична географія України</a></li>
</ul>
</div>
</section>
<section class='section'>
<h2>Публікації</h2>
<div><p><span style="color: #000000;">Видатні винниківчани: Науково &#8211; краєзнавче видання / А. Л. Байцар. – Львів-Винники, 2012. – 88 с.</span></p>
<p><span style="color: #000000;">Фізична географія України. Навчально-методичний посібник. – Львів. Видавн. центр ЛНУ ім. І. Франка, 2012 . – 354 с.</span></p>
<p>Крим. Нариси історичної, природничої і суспільної географії. Навчальний посібник. – Львів. Видавн. центр ЛНУ ім. І. Франка, 2007. – 224 с.</p>
<p>Фізична географія України. Навчально-методичний посібник. – Львів. Видавн. центр ЛНУ ім. І. Франка, 2007. – 172 с.</p>
<p><span style="color: #000000;">Практикум з фізичної географії України. – Львів. Видавн. центр ЛНУ ім. І. Франка, 2006.  50 с.</span></p>
<p><span style="color: #000000;">Чорногірський географічний стаціонар.. Навчальний посібник. – Львів. Вид &#8211; во Львів. ун-ту, 2003. – 132 с. (у співавторстві)</span></p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
</div>
</section>
<section class='section'>
<h2>Біографія</h2>
<div><p style="text-align: left;"><span style="color: #000000;"><br />
Народився 01.09.1966 р. (м. Винники). Закінчив географічний факультет Львівського університету (1988 р.). Працював старшим лаборантом кафедри фізичної географії (з 1988 р.). 1991–1996 рр. &#8211; асистент кафедри фізичної географії. 1994 р. захистив кандидатську дисертацію на тему «Верхня межа лісу в ландшафтних комплексах Українських Карпат».З 1996 р. – доцент кафедри географії України. Читає такі курси: «Фізична географія України»; «Географічна термінологія»; «Географія Украінських Карпат і Криму»; «Географія культур в Україні».</span></p>
<p><span style="color: #000000;">Автор понад 80 наукових праць, близько 130 науково-краєзнавчих статей.</span></p>
<p>&nbsp;</p>
</div>
</section>
<section class='section'>
<h2>Розклад</h2>
<div><p>Сторінка розкладу викладачів не знайдена!</p></div>
</section>
</article>
</main>"""

print(html2text.html2text(html))