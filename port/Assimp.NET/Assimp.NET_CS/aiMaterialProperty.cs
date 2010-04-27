/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiMaterialProperty : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiMaterialProperty(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiMaterialProperty obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiMaterialProperty() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AssimpPINVOKE.delete_aiMaterialProperty(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public aiString mKey {
    set {
      AssimpPINVOKE.aiMaterialProperty_mKey_set(swigCPtr, aiString.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AssimpPINVOKE.aiMaterialProperty_mKey_get(swigCPtr);
      aiString ret = (cPtr == IntPtr.Zero) ? null : new aiString(cPtr, false);
      return ret;
    } 
  }

  public uint mSemantic {
    set {
      AssimpPINVOKE.aiMaterialProperty_mSemantic_set(swigCPtr, value);
    } 
    get {
      uint ret = AssimpPINVOKE.aiMaterialProperty_mSemantic_get(swigCPtr);
      return ret;
    } 
  }

  public uint mIndex {
    set {
      AssimpPINVOKE.aiMaterialProperty_mIndex_set(swigCPtr, value);
    } 
    get {
      uint ret = AssimpPINVOKE.aiMaterialProperty_mIndex_get(swigCPtr);
      return ret;
    } 
  }

  public uint mDataLength {
    set {
      AssimpPINVOKE.aiMaterialProperty_mDataLength_set(swigCPtr, value);
    } 
    get {
      uint ret = AssimpPINVOKE.aiMaterialProperty_mDataLength_get(swigCPtr);
      return ret;
    } 
  }

  public aiPropertyTypeInfo mType {
    set {
      AssimpPINVOKE.aiMaterialProperty_mType_set(swigCPtr, (int)value);
    } 
    get {
      aiPropertyTypeInfo ret = (aiPropertyTypeInfo)AssimpPINVOKE.aiMaterialProperty_mType_get(swigCPtr);
      return ret;
    } 
  }

  public string mData {
    set {
      AssimpPINVOKE.aiMaterialProperty_mData_set(swigCPtr, value);
    } 
    get {
      string ret = AssimpPINVOKE.aiMaterialProperty_mData_get(swigCPtr);
      return ret;
    } 
  }

  public aiMaterialProperty() : this(AssimpPINVOKE.new_aiMaterialProperty(), true) {
  }

}
