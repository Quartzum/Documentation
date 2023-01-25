# Ускоренная обработка данных: lambda, filter, map, zip, enumerate, List Comprehension
---
---
## Анонимные(lambda функции)
---

Lambda функции позволяют записать функцию в одну строку кода.

## Функция map

Функция map() применяет указанную функцию к каждому элементу итерируемого объекта и возвращает итератор с новыми объектами.
```
f(x) => x + 10
map(f, [1, 2, 3, 4, 5])
       [11,12,13,14,15]
```
Нельзя пройтись дважды

## Функция filter

Функция filter() применяет указанную функцию к каждому элементу итерируемого объекта и возвращает итератор с теми объектами, для которых фунция вернула True.
```
f(x) => x - чётное
map(f, [1, 2, 3, 4, 5])
       [   12,   14]
```
Нельзя пройтись дважды

## Функция zip

Функция zip применяется к набору итерируемых объектов и возвращает итератор с кортежами из элементов входных данных.

Количество элементов в результате равно минимальному количеству элементов входного набора

```
zip([1,2,3], ['о', 'д', 'т'], ['f', 's', 't'])

[(1, 'o', 'f'), (2, 'д', 's'), (3, 'т', 't')]
```
Нельзя пройтись дважды

## Функция enumerate

Функция enumerate применяется к итерируемому объекту и возвращает новый итератор с кортежами из индекса и элементов входных данных.

```
enumerate(['Казань', 'Смоленск', 'Рыбки', 'Чикаого'])

[(0, 'Казань'), (1, 'Смоленск'), (2, 'Рыбки'),(3, 'Чикаого')]
```
Нельзя пройтись дважды

## List Comprehension

```
[exp for item in iterable]
[exp for item in iterable(if conditional)]
[exp <if conditional> for item in iterable (if conditional)]
```