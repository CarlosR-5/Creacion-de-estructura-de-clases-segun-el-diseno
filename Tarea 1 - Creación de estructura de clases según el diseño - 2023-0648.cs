using System;

//Carlos Rodriguez 2023-0648

public abstract class MiembroComunidad
{
    public int MiembroComunidadid { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public int Telefono { get; set; }
    public string Correo { get; set; }

    public abstract void Save();

    public virtual void get()
    {
      
    }
}

public class Empleado : MiembroComunidad
{
	public Empleado()
	{

	}

    public override void get()
    {
        base.get();
    }

    public override void Save()
    {
        throw new System.NotImplementedException();
    }
}

public class Estudiante : MiembroComunidad
{
    public Estudiante()
    {

    }

    public override void get()
    {
        base.get();
    }

    public override void Save()
    {
        throw new System.NotImplementedException();
    }
}

public class ExAlumno : MiembroComunidad
{
    public ExAlumno()
    {

    }

    public override void get()
    {
        base.get();
    }

    public override void Save()
    {
        throw new System.NotImplementedException();
    }
}

public class Docente : Empleado
{
    public Docente()
    {

    }

    public override void get()
    {
        base.get();
    }

    public override void Save()
    {
        base.Save();
    }
}

public class Administrativo : Empleado
{
    public Administrativo()
    {

    }

    public override void get()
    {
        base.get();
    }

    public override void Save()
    {
        base.Save();
    }
}

public class Administrador : Docente
{
    public Administrador()
    {

    }

    public override void get()
    {
        base.get();
    }

    public override void Save()
    {
        base.Save();
    }
}

public class Maestro : Docente
{
    public Maestro()
    {

    }

    public override void get()
    {
        base.get();
    }

    public override void Save()
    {
        base.Save();
    }
}