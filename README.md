<div class="text" align="center">
    <h2>Увлекательная игра в достижении заветной цифры 2048</h2>
</div>
<h3>Краткое объяснение</h3>
<p><em>Шуточная</em> игра для непринужденного время препровождения как одному так и в компании друзей </p>
<img src="" />
<h3>Правила игры</h3>
<img src="" />
<br />
<img src="" />
<br />
<p>По итогам игры участник игры получает <b>"шуточный"</b> итог игры, над которым все могут посмеяться</p>
<p>Взяв на себя функции администратора пользователь может изменять и дополнять вопросы для изменения игры</p>
<h3>Архитектурная часть</h3>
<img src="" />
<p>Работа выполнена с использованием общей бибилиотеки в коде</p>
<p>При разработки данной игры я прошел несколько важных шагов в изучении языка с#</p>
<ul>
    <li>Использование знаний по ООП для разделения сущностей и логики работы кода</li>
    <li>Использвоание формата Json для сохранения результатов игры</li>
    <li>Работа с файловой системой</li>
    <li>Проверка на валидность данных, использование try catch</li>
    <li>Возможность расширения списка вопросов и ответов для разнообразия игры</li>
</ul>
<h5>Особенно хотел бы отметить код для сохрарения в формате JSON</h5>

    public static void Append(string Path, string value)
    {
        var writer = new StreamWriter(Path, true, Encoding.UTF8);
        writer.WriteLine(value);
        writer.Close();
    }

    public static void Replace(string Path, string value)
    {
        var writer = new StreamWriter(Path, false, Encoding.UTF8);
        writer.WriteLine(value);
        writer.Close();
    }

    public static string GetValue(string Path)
    {
        var reader = new StreamReader(Path, Encoding.UTF8);
        var value = reader.ReadToEnd();
        reader.Close();
        return value;
    }

    public static bool Exists(string Path)
    {
        return File.Exists(Path);
    }

    public static void Save(string path, Password password)
    {
        var jsonData = JsonConvert.SerializeObject(password, Formatting.Indented);
        Replace(path, jsonData);
    }
<h2>Немного видео из игры</h2>

<a href="">Скачать видео</a>
 
<div class="text" align="center">
    <h1>Спасибо за внимание!</h2>
</div>
