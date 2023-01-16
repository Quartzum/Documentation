CREATE TABLE classmates(
    classmates_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(30),
    age INT,
    address VARCHAR(200)
);

INSERT INTO classmates (classmates_id, name, age, address) VALUES
    (1, 'Victor', 26, 'Moscow'),
    (2, 'Anna', 18, 'Moscow'),
    (3, 'Michail', 29, 'Moscow'),
    (4, 'Olga', 34, 'Onega'),
    (5, 'Anton', 60, 'Moscow');

SELECT name FROM classmates WHERE address = 'Moscow' AND age BETWEEN 18 AND 29;