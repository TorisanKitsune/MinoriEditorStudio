﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace MinoriEditorShell.VirtualCanvas.Services
{
    public interface IMesQuadTree<T> where T : class
    {
        RectangleF Bounds { get; set; }
        IMesQuadrant<T> Root { get; }

        IEnumerable<T> GetNodesInside(RectangleF bounds);

        Boolean HasNodesInside(RectangleF bounds);

        void Insert(T node, RectangleF bounds);

        System.Boolean Remove(T node);

        void ShowQuadTree(Object container);
    }
}