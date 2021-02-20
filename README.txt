Тк. в задании не было указано как имменно реалезованна связь многие ко многим, я написал свой простенький прототип и выполнил запрос к нему 
результат выполнения нижеописанных строк кода можно посмотреть в файлах 1.jpeg и 2.jpeg, находящихся в файлах проекта


CREATE TABLE product(
id INTEGER  PRiMARY KEY,
name TEXT NOT NULL
);


CREATE TABLE category(
id INTEGER  PRiMARY KEY,
name TEXT 
);


CREATE TABLE category_products(
product_id INTEGER NOT NULL,
category_id INTEGER NOT NULL,
FOREIGN KEY (product_id) REFERENCES product(id),
FOREIGN KEY (category_id) REFERENCES category(id)
);


SELECT category.name,product.name FROM category_products 
JOIN category ON category.id=category_products.category_id 
JOIN product ON product.id = category_products.product_id;


