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
    <Form className={css.form}>
        
        <div className="form-group">
            <label htmlFor="nombre" className={css.label}>Email</label> <br/>
            <Field name="nombre" className={css.field}/> <br/>
            <label htmlFor="contraseña" className={css.label}>Contraseña</label><br/>
            <Field name="contraseña" className={css.field}/>
        </div>
        </Form>

        </Formik>
        </>

)
}