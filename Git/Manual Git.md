# Manual Git
![Git](https://www.hostinger.com.ua/rukovodstva/wp-content/uploads/sites/8/2017/04/osnovnye-git-komandy.png)

>Git (произносится «гит»[7]) — распределённая система управления версиями. Проект был создан Линусом Торвальдсом для управления разработкой ядра Linux, первая версия выпущена 7 апреля 2005 года. На сегодняшний день его поддерживает Джунио Хамано.
>Среди проектов, использующих Git — ядро Linux, Swift, Android, Drupal, Cairo, GNU Core Utilities, Mesa, Wine, Chromium, Compiz Fusion, FlightGear, jQuery, PHP, NASM, MediaWiki, DokuWiki, Qt, ряд дистрибутивов Linux.
>Программа является свободной и выпущена под лицензией GNU GPL версии 2. По умолчанию используется TCP порт 9418. ~

# Chapter One - Introduction.
---
---

## 1.Введение.
---

VCS(Version Control System) - программа, позволяющая разработчикам переключаться между различными версиями проекта, а также работать с ними в команде, как локально, так и удаленно.

`VCS хранит не все версии файлов, а только их изменения`

## 2. Установка и авторизация.
---

Для того, чтобы установить VCS лучше всего воспользоваться самой популярной программой контроля версий - `Git.`

https://git-scm.com/ - сайт с Git.

После установки Git стоит проверить, что он установился глобально на вашем ПК. Зайдите в терминал(командную строку) и введите команду:

`git --version` - проверка версии Git.

После установки необходимо зайти в программу `Git Bash` и авторизоваться. Это необходимо для того, чтобы Git использовал эти данные при создании commit(сохранений версий) внутри локального/удаленного репозитория.

### Авторизация

`git config --global user.name "John Doe"` - установка глобального имени пользователя.

`git config --global user.email johndoe@example.com` - установка глобальной почты пользователя.

## 3.Инициализация локального репозитория
---

Репозитории бывают двух типов:

- Локальные - инициализируются на ПК владельца.
- Удаленные - инициализируются на сервере компании, которая предоставляют услуги хранения репозиториев.
Например:
1. GitHub - разработка Microsoft Corporation.
2. GitLab - разработка GitLab Inc.

Для того, чтобы инициализировать локальные репозиторий необходимо создать пустую папку, в которой вы будете работать. Открыть терминал и перейти внутри него в рабочую папку.
После этих действий можно приступить к созданию локального репозитория с помощью команды:

`git init` - создает локальный репозиторий внутри папки.

`Также, эта команда незаметно для нас создает базовую структуру для работы с репозиторем:`

- Создает ветку master(или main)
- Создает первый commit инициализации
- Создает невидимую папку .git , где хранятся настройки для программы Git.

После всех этих действий мы можем приступить к работе с локальным репозиторием.

```
Репозиторий состоит из:
1. Коммитов - это фиксация изменений внутри проекта. Еще их можно назвать версиями проекта, т.к. коммитов может быть неограниченное количество.
2. Ветки - это ответвление от какого-то конкретного коммита, которая имеет доступ к другим коммитам своего родителя.

```

## 4.Проверка статуса репозитория, добавление файла в отслеживаемые и работа с файлом .gitignore.
---

### Проверка статуса

Для того, чтобы проверить статус локального репозитория мы можем воспользоваться следующей командой:

`git status` - проверка статуса локального репозитория.

Команда показывает следующую информацию:
1. На какой ветке находится пользователь.
2. Есть ли какие-то файлы, которые не отслеживаются.
3. Есть ли какие-то файлы, в которых есть изменения.

### Отслеживание файлов и файл .gitignore

После того, как мы создадим какой-то файл, то Git, при выполнении команды `git status` сообщит о том, что есть не отслеживаемый файл.
У нас есть два варианта для работы с этим файлом:
1. Выполнить команду `git add somefile` или `git add .`.
- Первая команда добавит в отслеживаемые файлы Git, конкретный файл, который мы укажем.
- Вторая команда добавит все файлы находящиеся в папке в отслеживаемые Git.

2. Создать файл с названием .gitignore , в котором можно прописать файлы, которые мы не хотим отслеживать. Название файла зарезервировано, поэтому расширение можно не указывать.

## 5.Фиксация(сохранение) изменений.
---

Для того, чтобы сохранить изменений необходимо ввести следующую команду:

`git commit -m "Some description commit"` - создает сохранение изменений внутри ветки.

Флаг -m сокращение от message, которое позволяет добавить к сохранению его описание. Описание прописывается внутри двойных кавычек.

## 6.Просмотр логов.
---

Для того, чтобы просмотреть сохранения используется следующая команда:

`git log`

Команда показывает следующую информацию:

- Список сохранений
- Ветку сохранения
- Автора сохранения
- Дату и время сохранения
- Описание сохранения
- Хэш сохранения

#### Стоит понимать, что логи показываются только на конкретной ветке. То есть если мы имеем несколько веток и мы пытаемся просмотреть логи на конкретной ветке, то он покажет их только на ней.
#### Точно также действуют сохранения. Они остаются только на конкретной ветке.

## 6.Сравнение сохраненного файла(ов) с текущими.
---

Для сравнения файла с текущим необходимо ввести команду:

`git diff` - прописывает в терминал изменения в текущем файле по сравнению с последним сохраненным.

- Плюсом или зеленым цветом - добавление новых строк.
- Минусом или красным цветом - удаление строк.
- Синим - статистика изменений

Для того, чтобы выйти из просмотра изменений необходимо нажать кнопку `q`.

## 7. Переключение между сохранениями.
---

Когда мы вызываем логи, то можем взять хэш коммита:

`commit 5bd89de4c15e2b0032d30dec0153b8f8a211e4d7(HEAD -> master)`

Для того, чтобы перейти с текущего сохранения на необходимое нам - нужно:

- Скопировать цифры и буквы хэша
- Выполнить команду:

`git checkout someHash` - переключение из одного сохранения в то, которое мы укажем после checkout.

Для того, чтобы перейти из сохранения в основную ветку, где мы работаем необходимо выполнить команду:

`git checkout master` - переход в ветку master.

## 8.Ветки.
---

Ветки - это изолированное пространство.
Можно их представить в виде черновиков и чистовика.
Чистовик - ветка master/main.
Черновики - другие ветки, которые отходят от master/main.

Для просмотра существующих веток используется команда:

`git branch`

Для создания новой ветки используется команда:

`git branch nameBranch`

Веток может быть неограниченное количество.
Ветки позволяют:
- Отделить рабочую версию проекта от тестовых.
- Разделить проект на части(отдельно Backend, Frontend и т.п.)
- Разделить проект между разработчиками, чтобы потом все вместе склеить в один проект. Во время merge(слияний) происходит конфликты, которые чаще всего в компании решает один специализированные человек(или нет...).

## 9.Объединение коммитов из разных веток.
---

1. ### Merge.

Если у нас стоит задача объединить коммиты из двух разных веток, то мы можем выполнить следующую команду:

`git merge someBranch`

При ее выполнении, из какой-то конкретной ветки происходит не слияние веток(не объединение), а всего лишь создается один общий коммит, который хранит историю своих родителей - то есть ветки, которую мерджим и из которой мы делаем.

`Если повторить данную операцию и из другой ветки, то объединения не будет. Но теперь обе ветки будут иметь один общий коммит, а ветки будут иметь доступ к всей истории друг друга`

2. ### Rebase.

`git rebase someBranch`

При выполнении данной команды коммиты из той ветки, которую мы переносим встают следом за последним коммитом ветки, в которую мы переносим.

Данный позволяет напрямую СЛИТЬ ветки в одну и сделать более красивую последовательность коммитов.

## 10.Визуализация веток.
---

Для того, чтобы визуализировать ветки необходимо вызвать команду:

`git log --graph`

## 11.Удаление ветки.
---

Для удаления ветки необходимо выполнить следующую команду:

`git branch -d nameBranchDelete`

# Chapter Two - Remote repository
---
---

## 1. Git и GitHub.
---

Git - это программа для работы с репозиторями на локальном ПК, но для того, чтобы связать свой репозиторий с удаленным репозиторием используются специализированные сервисы - например `GitHub или GitLab`.

https://github.com/ - сайт GitHub.

https://gitlab.com/ - сайт GitLab.

Возможности без авторизации на сайте:

- Можно просматривать открытые репозитории
- Скачивать с открытых репозиториев проекты

С авторизацией:

- Отправлять свой локальный репозиторий на удаленный репозиторий

## 2.Клонирование удаленного репозитория.
---

Для того, чтобы скопировать удаленный репозиторий, неободимо зайти на сайте найти интересующий вас репозиторий и нажать на кнопку `Code` и скопировать ссылку на репозиторий.

Для клонирования используется команда:

`git clone someLinks`

Команда git clone составная: она не только загружает все изменения, но и пытается слить  все ветки на локальном компьютере и в удаленном репозитории.

## 3. Обновление проекта.
---

Для того, чтобы обновить свою версию проекта через удаленный репозиторий необходимо использовать команду:

`git pull`

Эта команда позволяет скачать все  из текущего репозитория и автоматически сделать merge с нашей версией.

## 4.Отправка проекта в удаленный репозиторий.
---

Отправить свою версию репозитория во внешний репозиторий поможет команда git push. При первом её использовании нужна авторизация.

`git push`

## 5. Настройка совместной работы.
---

1. Создать аккаунт на GitHub.
2. Создать локальный репозиторий.
3. “Подружить” ваш локальный и удалённый репозитории. GitHub при создании нового репозитория подскажет, как это можно сделать.
4. Отправить (push) ваш локальный репозиторий в удалённый (на GitHub), при этом, возможно,  вам нужно будет авторизоваться на удалённом репозитории.
5. Провести изменения “с другого компьютера”. 
6. Выкачать (pull) актуальное состояние из удалённого репозитория.

## 6. Pull request.
---

В больших компаниях один ответственный за проект создает аккаунт. Другие пользователи дают команду pull request. Предлагать изменения на GitHub нужно в отдельной ветке. Сначала пользователь копирует репозиторий на свой компьютер, делает fork репозитория, затем клонирует версию на своём ПК, создаёт ветку с предлагаемыми изменениями, отправляет изменения командой push в свой аккаунт на GitHub и даёт команду pull request.

### Как сделать pull request
---

- fork Делаем  (ответвление) репозитория СВОЕЙ 
- Делаем git clone  версии репозитория 
- Создаем новую ветку и в НЕЕ вносим свои изменения 
- Фиксируем изменения (делаем коммиты)
- Отправляем свою версию в свой GitHub 
- На сайте GitHub нажимаем кнопку pull request

# Chapter Three - Deep learning.
---
---

## 1.Новые команды.
---

`git checkout -b someName` - создание ветки и переход на нее.

`git checkout HEAD^1` - переход на один коммит назад от HEAD.

`git branch -f main HEAD~3` - принудительно переносит ветку main на 3 родителя назад от HEAD.

## 2.HEAD и относительные ссылки.
---

`HEAD - указывает на коммит или ветку, относительно которой будут совершаться операции.`

`Относительные ссылки - это то, относительно чего мы будем перемещаться по дереву коммитов.`

`Относительная ссылка HEAD используется, если нет желания искать хэш коммита.`

Можно перемещаться тремя способами:
1. Относительно ветки.
2. Относительно коммита.
3. Относительно HEAD(указывает на ветку или коммит).

`ХЭШ - адрес коммита. Можно брать только перые 4 символа.`

### Оператор ^

`^` - перемещение на одного родителя назад.
Можно использовать ^^, тогда переход осуществится на родителя родителя.

`git checkout HEAD^` - можно использовать HEAD, как относительную ссылку(чтобы не прописывать название ветки/коммита).

### Оператор ~

`~`- перемещение на несколько родителей назад.

## 4.Перемещение ветки.
---

`git branch -f main HEAD~3` - переместит (принудительно) ветку main на три родителя назад от HEAD.

## 3.Отмена изменений.
---

### Высокоуровненвая отмена:

1. Для локальных репозиториев:

`git reset` - отменяет изменения на один коммит назад. Используется для локальных репозиториев.
По сути он переписывает историю убирая коммит.

`ВАЖНО!Это не отменяет изменения на удаленных репозиториях!`

`git reset HEAD~1` - отменить один коммит.

2. Для удаленных репозиториев:

`git revert` - отменяет изменения на один коммит назад. Используется для удаленных репозиторев.

`git revert nameBranch`- отменяет изменения на один коммит назад для удаленного репозитория.

## 4. Cherry-pick.
---

Если нам необходимо вытащить конкретные коммиты из веток, и добавить их в другую ветку, то мы можем воспользоваться следующей командой:

`git cherry-pick <Commit1> <Commit2> <...>`

Количество коммитов неограничено.

## 5.Интерактивный rebase.
---

Для тех случаев, когд мы не знаем хэшей коммитов и как они должны быть располжены лучше всего подойдет интереактивный rebase.

`git rebase -i HEAD~4` - открывает диалоговое окно в текстовом редакторе, где мы можем вручную переставить коммиты, как мы захотим.