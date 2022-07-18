select * from Usuarios

create proc SP_ConsultarUsuario
	as
		begin 
		select * from Usuarios
		end

create proc sp_ConsultarUsuarioFiltro
	@nombre varchar(50)
	as
		begin
		select * from Usuarios where Nombre = @nombre
		end

create proc sp_AgregarUsuarios
@nombre varchar(50)='',
@clave varchar (30)=''
	as
		begin
		insert into Usuarios (Nombre,Clave) 
		values(@nombre, @clave)
		end

create proc sp_BorrarUsuario
@codigo int
as
	begin
	delete from Usuarios where Codigo = @codigo
	end

create proc sp_Actualizar
@codigo int,
@nombre varchar (50),
@clave varchar(30)
	as
	begin 
	update Usuarios set Nombre = @nombre, Clave = @clave where Codigo = @codigo
	end
exec SP_ConsultarUsuario