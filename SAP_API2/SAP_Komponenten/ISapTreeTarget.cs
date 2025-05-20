using System;
using System.Runtime.InteropServices;
using SAP_API.GUI;  // Ensure this exists if needed
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiTree
  {
    public interface ISapTreeTarget
    {
      [DispId(103)]
      object ColumnOrder { get; set; }

      [DispId(32008)]
      string Tooltip { get; }

      [DispId(32047)]
      int ScreenTop { get; }

      [DispId(32046)]
      int ScreenLeft { get; }

      [DispId(32006)]
      int Height { get; }

      [DispId(32005)]
      int Width { get; }

      [DispId(32004)]
      int Top { get; }

      [DispId(32009)]
      bool Changeable { get; }

      [DispId(32003)]
      int Left { get; }

      [DispId(32038)]
      GuiComponent Parent { get; }

      [DispId(32025)]
      string Id { get; }

      [DispId(32033)]
      bool ContainerType { get; }

      [DispId(32032)]
      int TypeAsNumber { get; }

      [DispId(32015)]
      string Type { get; }

      [DispId(32001)]
      string Name { get; }

      [DispId(32000)]
      string Text { get; set; }

      [DispId(32030)]
      bool Modified { get; }

      [DispId(32037)]
      string IconName { get; }

      [DispId(32042)]
      string AccTooltip { get; }

      [DispId(101)]
      string TopNode { get; set; }

      [DispId(100)]
      string SelectedNode { get; set; }

      [DispId(33706)]
      bool DragDropSupported { get; }

      [DispId(33705)]
      GuiCollection OcxEvents { get; }

      [DispId(33703)]
      string AccDescription { get; }

      [DispId(33702)]
      int Handle { get; }

      [DispId(33701)]
      GuiContextMenu CurrentContextMenu { get; }

      [DispId(33700)]
      string SubType { get; }

      [DispId(32019)]
      GuiComponentCollection Children { get; }

      [DispId(32069)]
      string DefaultTooltip { get; }

      [DispId(32061)]
      bool IsSymbolFont { get; }

      [DispId(32050)]
      GuiComponent ParentFrame { get; }

      [DispId(32045)]
      string AccTextOnRequest { get; }

      [DispId(32044)]
      string AccText { get; }

      [DispId(32043)]
      GuiComponentCollection AccLabelCollection { get; }

      [DispId(102)]
      int HierarchyHeaderWidth { get; set; }

      [DispId(302)]
      void SetCheckBoxState(string NodeKey, string ItemName, int state);

      [DispId(32024)]
      void SetFocus();

      [DispId(10)]
      void ClickLink(string NodeKey, string ItemName);

      [DispId(208)]
      void UnselectColumn(string ColumnName);

      [DispId(207)]
      void SelectColumn(string ColumnName);

      [DispId(206)]
      void SetColumnWidth(string ColumnName, int Width);

      [DispId(205)]
      void ExpandNode(string NodeKey);

      [DispId(204)]
      void CollapseNode(string NodeKey);

      [DispId(203)]
      void UnselectAll();

      [DispId(202)]
      void UnselectNode(string NodeKey);

      [DispId(201)]
      void SelectNode(string NodeKey);

      [DispId(200)]
      void SelectItem(string NodeKey, string ItemName);

      [DispId(9)]
      void DoubleClickItem(string NodeKey, string ItemName);

      [DispId(8)]
      void ItemContextMenu(string NodeKey, string ItemName);

      [DispId(7)]
      void HeaderContextMenu(string HeaderName);

      [DispId(6)]
      void PressHeader(string HeaderName);

      [DispId(209)]
      void PressKey(string Key);

      [DispId(5)]
      void ChangeCheckbox(string NodeKey, string ItemName, bool Checked);

      [DispId(3)]
      void NodeContextMenu(string NodeKey);

      [DispId(32068)]
      void ShowContextMenu();

      [DispId(4)]
      void PressButton(string NodeKey, string ItemName);

      [DispId(34100)]
      void SelectContextMenuItem(string FunctionCode);

      [DispId(210)]
      void EnsureVisibleHorizontalItem(string NodeKey, string ItemName);

      [DispId(34102)]
      void SelectContextMenuItemByPosition(string PositionDesc);

      [DispId(1)]
      void DoubleClickNode(string NodeKey);

      [DispId(2)]
      void DefaultContextMenu();

      [DispId(34101)]
      void SelectContextMenuItemByText(string Text);

      [DispId(211)]
      string FindNodeKeyByPath(string Path);

      [DispId(339)]
      bool GetIsEditable(string NodeKey, string ItemName);

      [DispId(337)]
      bool GetIsDisabled(string NodeKey, string ItemName);

      [DispId(336)]
      int GetItemHeight(string NodeKey, string ItemName);

      [DispId(335)]
      int GetItemWidth(string NodeKey, string ItemName);

      [DispId(334)]
      int GetItemTop(string NodeKey, string ItemName);

      [DispId(333)]
      int GetItemLeft(string NodeKey, string ItemName);

      [DispId(338)]
      object GetAllNodeKeys();

      [DispId(215)]
      object GetColumnHeaders();

      [DispId(32036)]
      GuiComponentCollection FindAllByNameEx(string Name, int Type);

      [DispId(32035)]
      GuiComponentCollection FindAllByName(string Name, string Type);

      [DispId(32034)]
      GuiComponent FindByNameEx(string Name, int Type);

      [DispId(32026)]
      GuiComponent FindByName(string Name, string Type);

      [DispId(32029)]
      GuiComponent FindById(string Id, object Raise = null);

      [DispId(31194)]
      GuiCollection DumpState(string InnerObject);

      [DispId(32039)]
      bool Visualize(bool On, object InnerObject = null);

      [DispId(332)]
      int GetNodeHeight(string Key);

      [DispId(331)]
      int GetNodeWidth(string Key);

      [DispId(330)]
      int GetNodeTop(string Key);

      [DispId(329)]
      int GetNodeLeft(string Key);

      [DispId(305)]
      object GetSelectedNodes();

      [DispId(304)]
      bool GetIsHighLighted(string NodeKey, string ItemName);

      [DispId(303)]
      object GetColumnTitles();

      [DispId(213)]
      int GetNodeChildrenCountByPath(string Path);

      [DispId(229)]
      string SelectedItemNode();

      [DispId(228)]
      string SelectedItemColumn();

      [DispId(227)]
      string GetNodePathByKey(string Key);

      [DispId(226)]
      bool GetCheckBoxState(string NodeKey, string ItemName);

      [DispId(306)]
      string GetNextNodeKey(string NodeKey);

      [DispId(225)]
      object GetColumnNames();

      [DispId(223)]
      object GetColumnCol(string colName);

      [DispId(222)]
      int GetSelectionMode();

      [DispId(221)]
      string GetParent(string CKey);

      [DispId(220)]
      string GetItemText(string Key, string Name);

      [DispId(219)]
      string GetNodeTextByKey(string Path);

      [DispId(218)]
      object GetSubNodesCol(string Path);

      [DispId(217)]
      object GetNodesCol();

      [DispId(216)]
      string GetNodeKeyByPath(string Path);

      [DispId(224)]
      int GetItemType(string Key, string Name);

      [DispId(307)]
      string GetPreviousNodeKey(string NodeKey);

      [DispId(308)]
      bool IsFolder(string NodeKey);

      [DispId(309)]
      bool IsFolderExpanded(string NodeKey);

      [DispId(328)]
      string GetHierarchyTitle();

      [DispId(327)]
      string GetStyleDescription(int nStyle);

      [DispId(326)]
      int GetNodeStyle(string NodeKey);

      [DispId(325)]
      int GetItemStyle(string NodeKey, string ItemName);

      [DispId(324)]
      object GetNodeItemHeaders(string NodeKey);

      [DispId(323)]
      [return: MarshalAs(UnmanagedType.U4)]
      uint GetNodeTextColor(string Key);

      [DispId(322)]
      [return: MarshalAs(UnmanagedType.U4)]
      uint GetItemTextColor(string Key, string Name);

      [DispId(321)]
      string GetNodeAbapImage(string Key);

      [DispId(320)]
      string GetAbapImage(string Key, string Name);

      [DispId(319)]
      string GetFocusedNodeKey();

      [DispId(318)]
      int GetColumnIndexFromName(string Key);

      [DispId(317)]
      string GetColumnTitleFromName(string Key);

      [DispId(316)]
      int GetNodeIndex(string Key);

      [DispId(315)]
      int GetNodeChildrenCount(string Key);

      [DispId(314)]
      int GetListTreeNodeItemCount(string NodeKey);

      [DispId(313)]
      int GetHierarchyLevel(string Key);

      [DispId(212)]
      string GetNodeTextByPath(string Path);

      [DispId(311)]
      string GetNodeToolTip(string NodeKey);

      [DispId(310)]
      bool IsFolderExpandable(string NodeKey);

      [DispId(214)]
      int GetTreeType();

      [DispId(312)]
      string GetItemToolTip(string Key, string Name);

      // Custom Subs and Functions
      void SelectNodesByText(string searchstring, string searchstring2, string searchstring3, string searchstring4, string searchstring5, string searchstring6);
    }

    public static void SelectNodesByText(string searchstring, string searchstring2, string searchstring3, string searchstring4, string searchstring5, string searchstring6)
    {
      StaticVariables.ReturnPath = null;
      GuiTree sapGuiTree = StaticVariables.SapObject as GuiTree;
      if (!string.IsNullOrWhiteSpace(searchstring))
      {
        LoopAndSearchTree("1", sapGuiTree, searchstring);
      }
      if (!string.IsNullOrWhiteSpace(searchstring2))
      {
        LoopAndSearchTree(StaticVariables.ReturnPath, sapGuiTree, searchstring2);
      }
      if (!string.IsNullOrWhiteSpace(searchstring3))
      {
        LoopAndSearchTree(StaticVariables.ReturnPath, sapGuiTree, searchstring3);
      }
      if (!string.IsNullOrWhiteSpace(searchstring4))
      {
        LoopAndSearchTree(StaticVariables.ReturnPath, sapGuiTree, searchstring4);
      }
      if (!string.IsNullOrWhiteSpace(searchstring5))
      {
        LoopAndSearchTree(StaticVariables.ReturnPath, sapGuiTree, searchstring5);
      }
      if (!string.IsNullOrWhiteSpace(searchstring6))
      {
        LoopAndSearchTree(StaticVariables.ReturnPath, sapGuiTree, searchstring6);
      }
    }

    public static void LoopAndSearchTree(string path, GuiTree guiTree, string searchstring)
    {
      object key = guiTree.GetNodeKeyByPath(path);
      object text = guiTree.GetNodeTextByPath(path);
      string[] substringArray = searchstring.Split(';');
      int substringResult = 0;
      for (int t = 0; t < substringArray.Length; t++)
      {
        int idx = text.ToString().IndexOf(substringArray[t]);
        if (idx > 0)
        {
          substringResult = 1;
        }
        else
        {
          substringResult = 0;
          break;
        }
      }
      if (substringResult > 0)
      {
        try
        {
          guiTree.SelectNode(key.ToString());
          guiTree.ExpandNode(key.ToString());
          guiTree.SelectedNode = key.ToString();
        }
        catch { }
        StaticVariables.ReturnPath = path;
        return;
      }
      if (key.ToString() == "" && path.Length <= 1)
      {
        // Do nothing.
      }
      else if (key.ToString() == "" && path.Length > 1)
      {
        int i = 1;
        object prev = path;
        path = GetNextParent(path);
        LoopAndSearchTree(path, guiTree, searchstring);
      }
      else
      {
        try
        {
          guiTree.ExpandNode(key.ToString());
        }
        catch { }
        if (Convert.ToInt32(guiTree.GetNodeChildrenCount(key.ToString())) > 0)
        {
          int i = 1;
          path = path + "/" + i;
          i++;
        }
        else
        {
          int lengt = path.Length;
          int last = Convert.ToInt32(path.Substring(lengt - 1));
          last++;
          path = path.Substring(0, lengt - 1) + last.ToString();
        }
        LoopAndSearchTree(path, guiTree, searchstring);
      }
    }

    public static string GetNextParent(string pat)
    {
      if (pat.IndexOf("/") >= 0)
      {
        string[] pathArray = pat.Split('/');
        int pathArrayCount = pathArray.Length;
        string tmpPath = "";
        int lastElement = 1;
        for (int j = 0; j < pathArrayCount - 1; j++)
        {
          if (j == pathArrayCount - 2)
          {
            lastElement = Convert.ToInt32(pathArray[j]);
            lastElement++;
            tmpPath = string.IsNullOrEmpty(tmpPath) ? lastElement.ToString() : tmpPath + "/" + lastElement.ToString();
          }
          else
          {
            tmpPath = string.IsNullOrEmpty(tmpPath) ? pathArray[j] : tmpPath + "/" + pathArray[j];
          }
        }
        return tmpPath;
      }
      else
      {
        return pat;
      }
    }
  }
}
