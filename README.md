<div class="text" align="center">
    <h2>Увлекательная игра в достижении заветной цифры 2048</h2>
</div>
<h3>Краткое объяснение</h3>
<p>Очень увлекательная игра по набору максимальных очков. </p>
<p>Игра для одного человека на одном экране</p>
<img src="https://github.com/user-attachments/assets/238e1662-c827-49d3-9318-7bf7c0d4da16" />
<h3>Правила игры</h3>
<img src="https://github.com/user-attachments/assets/e52c78f5-644c-4dd3-8eff-9d59e6f77482" />
<br />
<img src="https://github.com/user-attachments/assets/c9d69792-cef0-4415-934c-ca4a7c62a6d3" />
<br />
<p>В течении игры участник должен набрать 2048 очков! При каждом ходе появляются новые квадраты с цифрами, котрые надо двигат в рзаные стороны, чтобы они складывалисб</p>
<h3>Архитектурная часть</h3>
<img src="https://github.com/user-attachments/assets/cde02753-2830-4bb4-9304-c070f1c7a98b" />
<p>В данной работе много внимания уделено организации ячеек, их передвижению, работе с random</p>

<h5>Организация ячеек</h5>

    var label = new Label();
    label.BackColor = SystemColors.ButtonShadow;
    label.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
    label.Size = new Size(labelSize, labelSize);
    label.TextAlign = ContentAlignment.MiddleCenter;
    var x = start_x + indexColumn * (labelSize + padding);
    var y = start_y + indexRow * (labelSize + padding);
    label.Location = new Point(x, y);
    label.TextChanged += Label_TextChanged;
    return label;

 <h5>Оформление ячеек</h5>


    var label = (Label)sender;
    switch (label.Text)
    {
        case "": label.BackColor = SystemColors.ButtonShadow; break;
        case "2": label.BackColor = Color.FromArgb(238, 228, 218); break;
        case "4": label.BackColor = Color.FromArgb(231, 224, 200); break;
        case "8": label.BackColor = Color.FromArgb(242, 177, 121); break;
        case "16": label.BackColor = Color.FromArgb(245, 149, 99); break;
        case "32": label.BackColor = Color.FromArgb(255, 116, 85); break;
        case "64": label.BackColor = Color.FromArgb(245, 95, 58); break;
        case "128": label.BackColor = Color.FromArgb(247, 207, 95); break;
        case "256": label.BackColor = Color.FromArgb(153, 131, 60); break;
        case "512": label.BackColor = Color.FromArgb(207, 111, 41); break;
        case "1024": label.BackColor = Color.FromArgb(189, 15, 165); break;
        case "2048": label.BackColor = Color.FromArgb(212, 11, 57); break;
    }

 <h5>Пример перемещения</h5>


    for (int j = 0; j < mapSize; j++)
    {
        for (int i = mapSize - 1; i >= 0; i--)
        {
            if (labelsMap[i, j].Text != string.Empty)
            {
                for (int k = i - 1; k >= 0; k--)
                {
                    if (labelsMap[k, j].Text != string.Empty)
                    {
                        if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                        {
                            var number = int.Parse(labelsMap[i, j].Text);
                            score += number * 2;
                            labelsMap[i, j].Text = (number * 2).ToString();
                            labelsMap[k, j].Text = string.Empty;
                        }
                        break;
                    }
                }
            }
        }
    }

    for (int j = 0; j < mapSize; j++)
    {
        for (int i = mapSize - 1; i >= 0; i--)
        {
            if (labelsMap[i, j].Text == string.Empty)
            {
                for (int k = i - 1; k >= 0; k--)
                {
                    if (labelsMap[k, j].Text != string.Empty)
                    {
                        labelsMap[i, j].Text = labelsMap[k, j].Text;
                        labelsMap[k, j].Text = string.Empty;
                        break;
                    }
                }

            }
        }
    }

<h2>Немного видео из игры</h2>  

https://github.com/user-attachments/assets/67c5d280-103d-4270-9dc5-18be1edc05bd


<div class="text" align="center">
    <h1>Спасибо за внимание!</h2>
</div>
