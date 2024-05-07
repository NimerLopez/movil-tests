@Code
    ViewData("Title") = "Home Page"
End Code

<div class="container bg-light">
    <div class="text-center">
        <h1 class="mx-auto">Matematicas</h1>
        <hr />
    </div>

    <div class="row">
        <div class="col-md-6">
            <div class="custom-box text-center h-200 ">
                <div class="box-number">1</div>
                <h2>División</h2>
                <form action="@Url.Action("Division")" method="post" class="form-horizontal">
                    <div class="form-group">
                        <label for="dividendo" class="control-label col-sm-2">Dividendo:</label>
                        <div class="col-sm-10">
                            <input type="text" id="dividendo" name="dividendo" class="form-control" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="divisor" class="control-label col-sm-2">Divisor:</label>
                        <div class="col-sm-10">
                            <input type="text" id="divisor" name="divisor" class="form-control" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                            <input type="submit" value="Dividir" class="btn btn-primary" />
                            <p>Hola cambios</p>
                        </div>
                    </div>
                </form>
                <p>Resultado División: @ViewBag.Resultado</p>
            </div>
        </div>

        <div class="col-md-6">
            <div class="custom-box text-center h-200">
                <div class="box-number">2</div>
                <h2>Extraer Número</h2>
                <form action="@Url.Action("ExtraerNumero")" method="post" class="form-horizontal">
                    <div class="form-group">
                        <label for="cadena" class="control-label col-sm-2">Cadena:</label>
                        <div class="col-sm-10">
                            <input type="text" id="cadena" name="cadena" class="form-control" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                            <input type="submit" value="Extraer Número" class="btn btn-primary" />
                        </div>
                    </div>
                </form>
                <p>Resultado Extracción Número: @ViewBag.ResultadoExtraccionNumero</p>
            </div>
        </div>
    </div>
</div>
