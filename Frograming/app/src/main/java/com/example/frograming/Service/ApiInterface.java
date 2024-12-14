package com.example.frograming.Service;

import com.example.frograming.Entidades.OpcionesMenu;
import com.example.frograming.Entidades.Usuarios;
import com.example.frograming.Modelos.CuentoResponse;
import com.example.frograming.Modelos.EliminarPerfilResponse;
import com.example.frograming.Modelos.LastSesionResponse;
import com.example.frograming.Modelos.LeccionResponse;
import com.example.frograming.Modelos.LoginRequest;
import com.example.frograming.Modelos.LoginResponse;
import com.example.frograming.Modelos.PareoResponse;
import com.example.frograming.Modelos.PartidaRequest;
import com.example.frograming.Modelos.PartidaResponse;
import com.example.frograming.Modelos.PerfilResponse;
import com.example.frograming.Modelos.PreguntasResponse;
import com.example.frograming.Modelos.RankingResponse;
import com.example.frograming.Modelos.RecuperarRequest;
import com.example.frograming.Modelos.RecuperarResponse;
import com.example.frograming.Modelos.RegistroRequest;
import com.example.frograming.Modelos.SesionResponse;
import com.example.frograming.Modelos.UpdatePerfilRequest;
import com.example.frograming.Modelos.UpdatePerfilResponse;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.DELETE;
import retrofit2.http.GET;
import retrofit2.http.Header;
import retrofit2.http.Headers;
import retrofit2.http.POST;
import retrofit2.http.PUT;
import retrofit2.http.Path;

public interface ApiInterface {
    // Metodos para Autenticación
    //POST
    @Headers({"Content-Type: application/json", "Cache-Control: max-age=640000"})
    @POST("login")
    Call<LoginResponse> Loguear (@Body LoginRequest request);

    @Headers({"Content-Type: application/json", "Cache-Control: max-age=640000"})
    @POST("registro")
    Call<List<Usuarios>> Registrar (@Body RegistroRequest request);

    @Headers({"Content-Type: application/json", "Cache-Control: max-age=640000"})
    @POST("actualizar_contrasena")
    Call<List<RecuperarResponse>> ActualizarContrasena(@Body RecuperarRequest request);

    //GET
    @GET("tema")
    Call<List<OpcionesMenu>> TraerTemas ();

    @GET("perfil_config/{usuarioid}")
    Call<PerfilResponse> TraerPerfil(@Path("usuarioid") String usuarioid);

    @GET("principal/{usuarioid}")
    Call<LastSesionResponse> ultimaSesion(@Path("usuarioid") String usuarioid);

    @GET("eliminarUsuario/{usuarioid}")
    Call<List<EliminarPerfilResponse>> EliminarUsuario(@Path("usuarioid") String usuarioid);

    @GET("last_log/{usuarioid}")
    Call<List<SesionResponse>> TraerLastSesion(@Path("usuarioid") String usuarioid);

    //PUT
    @Headers({"Content-Type: application/json", "Cache-Control: max-age=640000"})
    @PUT("perfil")
    Call<List<UpdatePerfilResponse>> GuardarPerfil (@Body UpdatePerfilRequest request);


    //Métodos para Lección
    //GET
    @GET("leccion/{temaid}")
    Call<LeccionResponse> TraerLeccion (@Path("temaid") String temaid);

    @GET("leccion_cuento/{temaid}")
    Call<List<CuentoResponse>> TraerCuento (@Path("temaid") String temaid);

    @GET("tutorial")
    Call<LeccionResponse> TraerTutorial ();

    //Métodos para ranking
    //GET
    @GET("ranking/{temaid}")
    Call<List<RankingResponse>> ObtenerRaking (@Path("temaid")  int tema_id);

    //Métodos para jugabilidad
    //GET
    @GET("preguntas/{temaid}")
    Call<List<PreguntasResponse>> getPreguntas(@Path("temaid") int tema_id);

    @GET("preguntas_pareo/{temaid}")
    Call<List<PareoResponse>> obtenerListadoPareo(@Path("temaid") int tema_id);

    //POST
    @Headers({"Content-Type: application/json", "Cache-Control: max-age=640000"})
    @POST("partida")
    Call<List<PartidaResponse>> Partida (@Body PartidaRequest request);
}
