import {Field, Form, Formik} from "formik";
import React from "react";
import logo from "../img/logo.png";
import css from "./Login.module.css";

export  default  function Login(){

    return (
        <>

            <Formik initialValues={
    {nombre: ''}
} onSubmit={values => {console.log(values)}} >
    <Form>
        <div className={css.div}>

        </div>

        <div className="form-group">
            <label htmlFor="nombre">Email</label>
            <Field name="nombre" className="form-control" />
            <label htmlFor="contraseña">Contraseña</label>
            <Field name="contraseña" className="form-control" />
        </div>
        </Form>

        </Formik>
        </>

)
}