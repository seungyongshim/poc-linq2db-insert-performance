explain select * from history
where CreateAt < unix_timestamp('2022-01-11');
select from_unixtime(CreateAt)
from history;

insert into history (CreateAt, Receiver, Title, Content) value (unix_timestamp('2022-01-10'), 'hello', 'world', 'what');

