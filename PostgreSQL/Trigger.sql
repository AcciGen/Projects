-- Task 1
--create or replace function myfunc_trigger()
--	returns trigger
--	language PLPGSQL
--	as $$
--	begin
--	 -- logic
--		if old.customer_id <> new.customer_id then
--		insert into archive_customers(id, customer_id, first_name, last_name, age, lastId)
--		values (old.id, new.customer_id, old.first_name, old.last_name, old.age, old.customer_id);
--	
--		end if;
--		return new;
--	end
--	$$
	
--  create trigger customerId_changes
--	before update
--	on customers
--	for each row
--	execute procedure myfunc_trigger()

--update customers
--set customer_id = 696
--where customer_id = 777

--select * from customers
--order by customer_id desc
--select * from archive_customers

--create table archive_customers (
--	id serial,
--	customer_id bigint,
--	first_name varchar(50),
--	last_name varchar(50),
--	age int,
--	lastId bigint
--)

-- Task 2
create table subjects (
	id bigserial,
	subjectName varchar(50) unique not null,
	primary key(id)
)

create table groups (
	id bigserial,
	groupName varchar(50),
	subjectId int,
	primary key(id),
	constraint fk_subject
		foreign key(subjectId)
			references subjects(id)
)

create table students (
	id bigserial,
	fullName varchar(50),
	primary key(id)
)

create table StudentsGroups (
	id bigserial,
	studentId int not null,
	groupId int not null,
	primary key(id, studentId, groupId),
	foreign key(studentId) references students(id),
	foreign key(groupId) references groups(id)
)

select * from subjects
select * from groups
select * from students
select * from StudentsGroups
select * from updated_datas

insert into subjects(subjectName) values ('Math'), ('English'), ('Russian')
insert into groups(groupName, subjectId) values ('Geniuses', 1), ('Rossiya Rulit', 3), ('UK KINGS', 2)
insert into students(fullName) values ('Nuriddin Asrorov'), ('Ibrohim Qosimov'), ('Ozodbek Olimjanov')
insert into StudentsGroups(studentId, groupId) values (1, 3), (2, 2), (3, 1)


create table updated_datas (
	id bigserial,
	old_fullName varchar(50),
	fullName varchar(50),
	old_subjectName varchar(50),
	subjectName varchar(50),
	old_groupName varchar(50),
	groupName varchar(50),
	old_subjectId int,
	subjectId int,
	primary key(id)
)

create or replace function students_trigger()
    returns trigger
    language plpgsql
	as $$
	begin
    	-- logic
    	if old.fullName <> new.fullName then
        	insert into updated_datas(old_fullName, fullName, old_subjectName, subjectName, old_groupName, groupName, old_subjectId, subjectId)
        	values (old.fullName, new.fullName, null, null, null, null, null, null);
    	end if;

    	return new;
	end
	$$;

create or replace function subjects_trigger()
    returns trigger
    language plpgsql
	as $$
	begin
    	-- logic
    	if old.subjectName <> new.subjectName then
        	insert into updated_datas(old_fullName, fullName, old_subjectName, subjectName, old_groupName, groupName, old_subjectId, subjectId)
        	values (null, null, old.subjectName, new.subjectName, null, null, null, null);
    	end if;

    	return new;
	end
	$$;

create or replace function groups_trigger()
    returns trigger
    language plpgsql
	as $$
	begin
    	-- logic
    	if old.groupName <> new.groupName or old.subjectId <> new.subjectId then
        	insert into updated_datas(old_fullName, fullName, old_subjectName, subjectName, old_groupName, groupName, old_subjectId, subjectId)
        	values (null, null, null, null, old.groupName, new.groupName, old.subjectId, new.subjectId);
    	end if;

    	return new;
	end
	$$;

create trigger students_changes
    before update
    on students
    for each row
    execute procedure students_trigger();

create trigger subjects_changes
    before update
    on subjects
    for each row
    execute procedure subjects_trigger();

create trigger groups_changes
    before update
    on groups
    for each row
    execute procedure groups_trigger();

update students
set fullName = 'Den Rov'
where fullName = 'Nuriddin Asrorov';

update subjects
set subjectName = 'Biology'
where subjectName = 'Math';

update groups
set groupName = 'Researchers', subjectId = 1
where groupName = 'Geniuses';
