Custom Properties Support
=========================

The `Tiled Map Editor <https://www.mapeditor.org/>`__ has support for `Custom Properties <http://doc.mapeditor.org/en/stable/manual/custom-properties/>`__
that allow you to include custom data or information along with components of your map.

.. figure:: img/objects-xml/props-tiled.png
   :alt: Custom Properties in Tiled
   
   Tiled Custom Properties

These custom properties are also **supported by SuperTiled2Unity** and can be found on the :code:`SuperCustomProperties` Monobehaviour component when imported in your Unity project.

.. figure:: img/objects-xml/props-unity.png
   :alt: Custom Properties in Unity
   
   SuperTiled2Unity Custom Properties

Obejct Types Support
--------------------

Tiled also has *predefined* properties that are described through the 
`Object Types Editor <http://doc.mapeditor.org/en/stable/manual/custom-properties/?highlight=object%20type#predefining-properties>`__.

.. figure:: img/objects-xml/object-types-editor.png
   :alt: Object Types Editor
   
   Object Types Editor

This is a time-saving way to create classes or groups of properties. However, by default, SuperTiled2Unity has no way of being aware of these predefined properties.
This can be resolved by **exporting the Object Types Xml file** to your Unity project.

First, select :code:`Export Object Types...` from the :code:`File` menu item.

.. figure:: img/objects-xml/export-objects-types.png
   :alt: Export Object Types Xml
   
   Select **Export Object Types** from the File menu item

This will bring up the save file dialog. Save your object types Xml file somewhere within your Unity project.

.. figure:: img/objects-xml/export-save-dialog.png
   :alt: Save Dialog
   
   Save Object Types Xml file to your Unity Project

.. tip::
   You can export your Object Types Xml file to any filename but make sure it is somewhere under your Unity project's :code:`Assets` directory.
   This Xml file itself will need to be a Unity asset that is referenced by SuperTiled2Unity's settings.

We now need to make SuperTiled2Unity aware of this exported Object Types Xml file. Select :code:`Assets/SuperTiled2Unity/S2TU Settings` within your Unity project.

.. figure:: img/objects-xml/st2u-settings.png
   :alt: SuperTiled2Unity Settings
   
   Select S2TU Settings asset in your Unity project

In the Inspector you should see a field for :code:`Object Types Xml`. Either drag and drop your recently exported Object Types Xml filed into this field or use the
asset selector button to select the asset.

.. figure:: img/objects-xml/inspector-apply.png
   :alt: S2TU Inspector
   
   Drag and drop your exported object types Xml file into the **Object Types Xml** field and hit **Apply**

With the Object Types Xml file now set hit :code:`Apply` in the Inspector. You should now be able to expand the list of :code:`Custom Object Types` and see your predefined
objects, including properties and colors, displayed.


.. figure:: img/objects-xml/inspector-done.png
   :alt: S2TU Inspector Done
   
   Custom properties for object types should be visible now

Now, any in your Unity project that are updated should have these predefined properties in the appropriate :code:`SuperCustomProperties` instances.

.. warning::
   Note that SuperTiled2Unity does not automatically update map assets when changes to the Object Types Xml are made.
   See the :code:`Reimport Tiled Assets` button in the :code:`SuperTiled2Unity Project Settings` inspector if you want to update all Tiled assets in your Unity project.
   **This may take some time** depending on the number and complexity of your Tiled assets, however.
