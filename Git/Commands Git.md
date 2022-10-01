# 1. Команды Git Bush:
---

`git config --global user.name` - посмотреть свое имя в Git.

`git config --global user.email` - посмотреть свой email в Git.

`git config --global user.name "Name Family"` - изменить свое имя в Git.

`git config --global user.email "Some email"` - изменить свой email в Git.

# 2. Base Git Command:
---

## Справка:
---
`git --version` - версия Git.

`git --help`- команды Git.

## Основные:
---

`git init` - инициализация локального репозитория.

`git status` - выводит в терминал информацию о статусе локального репозитория.

`git branch` - выводит в терминал информацию о существующих ветках.

`git add NameFile` - добавить в отслеживанье Git конкретный файл.

`git add .` - добавить все файлы в отслеживанье Git.

`git commit -m "SomeText"` - создание коммита.

`git remote add origin https://github.com/NameUser/test-projects.git` - соединяет локальный репозиторий с удаленным.

`git push -u origin NameBranch` - отправляет файлы из локального репозитория в удаленный.

## Работа с ветками:
---

`git branch NameBranch` - создание ветки.

`git branch -D NameBranch` - удаление ветки.

`git checkout Name` - переход на другую ветку или коммит.

`git checkout -b NameBranch` - создание ветки и переход на нее.

`git merge NameBranch` - слияние ветки после слова merge с веткой, в которой момент находится пользователь.

## Работа с репозиториями:
---

`git remote rm origin` - отсоединиться от удаленного репозитория.

`git clone https://github.com/NameUser/some-rep.git` - клонирование репозитория.

`git pull` - git fetch + git merge.

## Логи:
---

`git log` - показывает логи в терминале.

`git diff` - показывает изменения в текущем файле, с тем который закомичен.

## Вспомогательные:
---

`git rm --cached NameFile.txt` - удалить файл из отслеживанья Git.

`git rm -f NameFile` - удалить файл из папки и отслеживанья.