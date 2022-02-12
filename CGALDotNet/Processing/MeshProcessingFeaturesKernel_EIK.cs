﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

using CGALDotNetGeometry.Numerics;

namespace CGALDotNet.Processing
{
    internal class MeshProcessingFeaturesKernel_EIK : MeshProcessingFeaturesKernel
    {
        internal override string KernelName => "EIK";

        internal static readonly MeshProcessingFeaturesKernel Instance = new MeshProcessingFeaturesKernel_EIK();

        internal override IntPtr Create()
        {
            return MeshProcessingFeatures_EIK_Create();
        }

        internal override void Release(IntPtr ptr)
        {
            MeshProcessingFeatures_EIK_Release(ptr);
        }

        //Polyhedron

        internal override int DetectSharpEdges_PH(IntPtr feaPtr, IntPtr meshPtr, double feature_angle)
        {
            return MeshProcessingFeatures_EIK_DetectSharpEdges_PH(feaPtr, meshPtr, feature_angle);
        }

        internal override void GetSharpEdges_PH(IntPtr feaPtr, IntPtr meshPtr, int[] indices, int count)
        {
            MeshProcessingFeatures_EIK_GetSharpEdges_PH(feaPtr, meshPtr, indices, count);
        }

        internal override Index2 SharpEdgesSegmentation_PH(IntPtr feaPtr, IntPtr meshPtr, double feature_angle)
        {
            return MeshProcessingFeatures_EIK_SharpEdgesSegmentation_PH(feaPtr, meshPtr, feature_angle);
        }

        internal override void ClearPatchBuffer_PH(IntPtr feaPtr)
        {
            MeshProcessingFeatures_EIK_ClearPatchBuffer_PH(feaPtr);
        }

        internal override int GetPatchBufferFaceCount_PH(IntPtr feaPtr, int patchIndex)
        {
            return MeshProcessingFeatures_EIK_GetPatchBufferFaceCount_PH(feaPtr, patchIndex);
        }

        internal override int GetPatchBufferFaceIndex_PH(IntPtr feaPtr, int patchIndex, int faceIndex)
        {
            return MeshProcessingFeatures_EIK_GetPatchBufferFaceIndex_PH(feaPtr, patchIndex, faceIndex);
        }

        internal override MinMaxAvg EdgeLengthMinMaxAvg_PH(IntPtr ptr)
        {
            return MeshProcessingFeatures_EIK_EdgeLengthMinMaxAvg_PH(ptr);
        }

        internal override MinMaxAvg FaceAreaMinMaxAvg_PH(IntPtr ptr)
        {
            return MeshProcessingFeatures_EIK_FaceAreaMinMaxAvg_PH(ptr);
        }

        //Surface Mesh

        internal override int DetectSharpEdges_SM(IntPtr feaPtr, IntPtr meshPtr, double feature_angle)
        {
            return MeshProcessingFeatures_EIK_DetectSharpEdges_SM(feaPtr, meshPtr, feature_angle);
        }

        internal override void GetSharpEdges_SM(IntPtr feaPtr, IntPtr meshPtr, int[] indices, int count)
        {
            MeshProcessingFeatures_EIK_GetSharpEdges_SM(feaPtr, meshPtr, indices, count);
        }

        internal override Index2 SharpEdgesSegmentation_SM(IntPtr feaPtr, IntPtr meshPtr, double feature_angle)
        {
            return MeshProcessingFeatures_EIK_SharpEdgesSegmentation_SM(feaPtr, meshPtr, feature_angle);
        }

        internal override void ClearPatchBuffer_SM(IntPtr feaPtr)
        {
            MeshProcessingFeatures_EIK_ClearPatchBuffer_SM(feaPtr);
        }

        internal override int GetPatchBufferFaceCount_SM(IntPtr feaPtr, int patchIndex)
        {
            return MeshProcessingFeatures_EIK_GetPatchBufferFaceCount_SM(feaPtr, patchIndex);
        }

        internal override int GetPatchBufferFaceIndex_SM(IntPtr feaPtr, int patchIndex, int faceIndex)
        {
            return MeshProcessingFeatures_EIK_GetPatchBufferFaceIndex_SM(feaPtr, patchIndex, faceIndex);
        }

        internal override MinMaxAvg EdgeLengthMinMaxAvg_SM(IntPtr ptr)
        {
            return MeshProcessingFeatures_EIK_EdgeLengthMinMaxAvg_SM(ptr);
        }

        internal override MinMaxAvg FaceAreaMinMaxAvg_SM(IntPtr ptr)
        {
            return MeshProcessingFeatures_EIK_FaceAreaMinMaxAvg_SM(ptr);
        }

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern IntPtr MeshProcessingFeatures_EIK_Create();

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern void MeshProcessingFeatures_EIK_Release(IntPtr ptr);

        //Polyhedron
        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern int MeshProcessingFeatures_EIK_DetectSharpEdges_PH(IntPtr feaPtr, IntPtr meshPtr, double feature_angle);

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern void MeshProcessingFeatures_EIK_GetSharpEdges_PH(IntPtr feaPtr, IntPtr meshPtr, [Out] int[] indices, int count);

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern Index2 MeshProcessingFeatures_EIK_SharpEdgesSegmentation_PH(IntPtr feaPtr, IntPtr meshPtr, double feature_angle);

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern void MeshProcessingFeatures_EIK_ClearPatchBuffer_PH(IntPtr feaPtr);

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern int MeshProcessingFeatures_EIK_GetPatchBufferFaceCount_PH(IntPtr feaPtr, int patchIndex);

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern int MeshProcessingFeatures_EIK_GetPatchBufferFaceIndex_PH(IntPtr feaPtr, int patchIndex, int faceIndex);

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern MinMaxAvg MeshProcessingFeatures_EIK_EdgeLengthMinMaxAvg_PH(IntPtr ptr);

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern MinMaxAvg MeshProcessingFeatures_EIK_FaceAreaMinMaxAvg_PH(IntPtr ptr);

        //Surface Mesh
        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern int MeshProcessingFeatures_EIK_DetectSharpEdges_SM(IntPtr feaPtr, IntPtr meshPtr, double feature_angle);

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern void MeshProcessingFeatures_EIK_GetSharpEdges_SM(IntPtr feaPtr, IntPtr meshPtr, [Out] int[] indices, int count);

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern Index2 MeshProcessingFeatures_EIK_SharpEdgesSegmentation_SM(IntPtr feaPtr, IntPtr meshPtr, double feature_angle);

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern void MeshProcessingFeatures_EIK_ClearPatchBuffer_SM(IntPtr feaPtr);

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern int MeshProcessingFeatures_EIK_GetPatchBufferFaceCount_SM(IntPtr feaPtr, int patchIndex);

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern int MeshProcessingFeatures_EIK_GetPatchBufferFaceIndex_SM(IntPtr feaPtr, int patchIndex, int faceIndex);

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern MinMaxAvg MeshProcessingFeatures_EIK_EdgeLengthMinMaxAvg_SM(IntPtr ptr);

        [DllImport(DLL_NAME, CallingConvention = CDECL)]
        private static extern MinMaxAvg MeshProcessingFeatures_EIK_FaceAreaMinMaxAvg_SM(IntPtr ptr);

    }
}
